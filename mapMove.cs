using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapMove : MonoBehaviour
{
    public float hiz = 10f;
    private bool facingRight;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        facingRight = false;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector2 position = transform.position;
        position.x = position.x + 11.0f * horizontal * Time.deltaTime;
        position.y = position.y + 11.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
       

        Flip(horizontal);
    }
    private void Flip(float horizontal)
    {

        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
