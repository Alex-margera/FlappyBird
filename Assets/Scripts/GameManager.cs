using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject tubes;
    public float spawnTime;
    public GameObject RootTubes;

    void Awake()
    {
        
        
    }

    void Start()

    
    {
        StartCoroutine(GenerateTubes());   
    }

    IEnumerator GenerateTubes()
    {
        Vector2 position;

        while (true)
        {
            position = transform.position;
            position.x += 6f;
            Instantiate(RootTubes, position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }


    void Update()
    {
        
    }


}
