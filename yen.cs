using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yen : MonoBehaviour
{
    private Rigidbody2D rb;
    public static int totalYen = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            totalYen++;

            Destroy(gameObject);

        }

    }
}
