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


    private Animator animator;
    private int score;
    public int JumpForce;
    private int Vertical;

 

   
    void Update()
    {
        var rb = GetComponent < Rigidbody2D > ();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }

      

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tube")
        {
            Invoke("Restart", restartLevelDelay);
            enabled = false;

        }
        else if (other.tag == "Floor")
        {
            Invoke("Restart", restartLevelDelay);
            enabled = false;
        }
        else if (other.tag == "Roof")
        {
            Invoke("Restart", restartLevelDelay);
            enabled = false;
        }
    }
}

