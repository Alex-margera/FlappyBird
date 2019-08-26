using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Character : MonoBehaviour

{
    
    public Text scoreText;
    public AudioClip moveSound1;
    public AudioClip gameOverSound;
    public float restartLevelDelay;
    private GameManager gameManager;
    private bool gameOver;
    private Animator animator;
    public int JumpForce;
    [SerializeField] private Text gameOverText;
    public Button restartButton;
    private bool restart;
    public int score;


    private void Start()
    {
        gameOver = false;
        restart = false;
        gameOverText.text = "";
        score = 0;
        UpdateScore();
    }

    private void Awake()
    {
        gameManager = Camera.main.GetComponent<GameManager>();   
    }

    void Update()
    {
        var rb = GetComponent < Rigidbody2D > ();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
        if (restart)
        {
            if (restartButton.onClick.Equals(true))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
            else
            {
                return;
            }
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
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
        if (gameOver)
        {
            restartButton.gameObject.SetActive(true);
            restart = true;
           


        }
      






    }

    void OnTriggerExit2D(Collider2D other)

        {

            score++;

        }
   

    public void GameOver()

    {

        gameOverText.text = "Game Over!";
        gameOver = true;



    }

    void UpdateScore()
    {
        scoreText.text = "Score :" + score;

    }

   

   



}

