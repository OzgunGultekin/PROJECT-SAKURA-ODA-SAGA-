using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sushi : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
