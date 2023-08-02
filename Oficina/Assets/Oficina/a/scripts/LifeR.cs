using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeR : MonoBehaviour
{

    public int healthValue;
    private AudioSource sound;

    public void Update()
    {
        sound = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D CO)
    {
        if (CO.gameObject.tag == "Player")
        {
            sound.Play();
            CO.gameObject.GetComponent<Player>().IncreaseLife(healthValue);
            Destroy(gameObject, 0.1f);
        }
    }
    
}
