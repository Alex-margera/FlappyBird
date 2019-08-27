using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeMover : MonoBehaviour
{
    [SerializeField] private float speed;

    void Awake()
    {
        Vector2 position = transform.position;

        position.y = Random.Range(-5.36F, -1.48F);

        transform.position = position;

        Destroy(gameObject, 6.0F);
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);
    }
}
