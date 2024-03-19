using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public float hiz = 10f;
    public float ziplamaGucu = 1000f;
    private bool zipliyor = false;
    private Rigidbody2D rb;
    public Animator animator;
    private bool facingRight;
    


    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        facingRight = false;
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * hiz, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        Vector2 position = transform.position;
       
        transform.position = position;
        if (Input.GetKeyDown(KeyCode.Space) && !zipliyor)
        {
            zipliyor = true;
            rb.AddForce(new Vector2(0f, ziplamaGucu));
            
            animator.SetBool("isJump", true);
            
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            
            animator.SetBool("isAttack1", true);
           
             
        }

        if (Input.GetKeyDown(KeyCode.C))
        {

            animator.SetBool("isAttack2", true);
        }

    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Flip(horizontal);

        animator.SetBool("isAttack1", false);
        animator.SetBool("isAttack2", false);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            zipliyor = false;
            animator.SetBool("isJump", false);

        }
        
        

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
