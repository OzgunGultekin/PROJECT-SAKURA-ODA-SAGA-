using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yenCounter : MonoBehaviour
{
    Text counterText;

    
    void Start()
    {
        counterText = GetComponent<Text>();
    }

 
    void Update()
    {
        
        if (counterText.text != yen.totalYen.ToString())
        {
            counterText.text = yen.totalYen.ToString();
        }
    }
}
