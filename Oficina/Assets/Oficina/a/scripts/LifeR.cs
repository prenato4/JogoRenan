using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeR : MonoBehaviour
{

    public int healthValue;
    

    public void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D CO)
    {
        if (CO.gameObject.tag == "Player")
        {
            
            CO.gameObject.GetComponent<Player>().IncreaseLife(healthValue);
            Destroy(gameObject, 0.1f);
        }
    }
    
}
