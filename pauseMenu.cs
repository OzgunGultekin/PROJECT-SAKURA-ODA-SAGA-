using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu1;

    void Start()
    {

        pauseMenu1 = GameObject.FindWithTag("pauseMenu");
        pauseMenu1.SetActive(false);
    }
   
    public void stop()
    {
        pauseMenu1.SetActive(true);
        Time.timeScale = 0f;
    }
}
