using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healtBarCode : MonoBehaviour
{
    public Slider HealthBorder2;
    public Health playerHealth;

    public void getHealth(int health)
    {
        HealthBorder2.value = health;
    }

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        HealthBorder2 = GetComponent<Slider>();
        HealthBorder2.maxValue = playerHealth.maximumHealth;
        HealthBorder2.value = playerHealth.maximumHealth;
    }

}
