using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   public int scoreValue;
   


   private void Update()
   {
      
   }

   private void OnTriggerEnter2D(Collider2D CO)
   {
      if (CO.gameObject.tag == "Player")
      {
         gamecontroller.instance.UpdateScore(scoreValue);
         Destroy(gameObject, 0.1f);
      }
   }
}
