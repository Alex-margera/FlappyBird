using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour

{

    public AudioClip moveSound1;
    public AudioClip gameOverSound;
    public float restartLevelDelay;
    private GameManager gameManager;
    private bool gameOver;
    private Animator animator;
    public int JumpForce;
    public Text gameOverText;
    public Button restartButton;
    private bool restart;
    public int score;
    public float force;
    


    private new Rigidbody2D rigidbody;

    

    void Awake()

    {

        rigidbody = GetComponent<Rigidbody2D>();

        gameManager = Camera.main.GetComponent<GameManager>();

    }

    void Update()

    {
        

        if (Input.GetKeyDown(KeyCode.Space))

            rigidbody.AddForce(Vector2.up * (force - rigidbody.velocity.y), ForceMode2D.Impulse);

        rigidbody.MoveRotation(rigidbody.velocity.y * 2.0F);

        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Restart();
            }


        }

    }

    void OnTriggerEnter2D(Collider2D other)

    {

        if (other.tag == "Tube")
        {
            GameOver();
            Time.timeScale = 0.0f;
        }
        else if (other.tag == "Floor")
        {
            GameOver();
            Time.timeScale = 0.0f;
        }
        else if (other.tag == "Roof")
        {
            GameOver();
            Time.timeScale = 0.0f;
        }
        else if (other.tag == "Score")
        {
            gameManager.score++;
        }

      


    }



    public void GameOver()

    {

        restartButton.gameObject.SetActive(true);
        gameOverText.text = "Game Over!";
        gameOverText.gameObject.SetActive(true);
        gameManager.scoreText.gameObject.SetActive(true);

        gameOver = true;
        restart = true;
       
    }

   

    public void Restart()

    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0F;
        
    }




}

