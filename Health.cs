using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public healtBarCode healthBar;
    public int currentHealth = 0;
    public int maximumHealth = 100;

    void Start()
    {
        currentHealth = maximumHealth;
    }

    
    void Update()
    {
        
     
        if (currentHealth <= 0)
        {
            closeGame();
        }
    }
    public void closeGame()
    {
        Application.Quit();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            currentHealth -= 10;

            healthBar.getHealth(currentHealth);
        }
        if (col.gameObject.CompareTag("sushi"))
        {
            currentHealth += 10;
            healthBar.getHealth(currentHealth);
        }

    }
}
