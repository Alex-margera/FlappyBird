﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text scoreText;

    [SerializeField]

    public GameObject tubes;

    [HideInInspector]

    public int score;

    void Awake()

    {
        

    }

    void Start()

    {
        
        StartCoroutine(GeneratePipes());
    }

    void Update()

    {
        scoreText.text = "Score: " + score;

    }

    IEnumerator GeneratePipes()

    {

        Vector2 position;

        while (true)

        {

            position = transform.position;

            position.x += 6.0F;

            Instantiate(tubes, position, Quaternion.identity);

            yield return new WaitForSeconds(2.0F);

        }



    }

   
}
