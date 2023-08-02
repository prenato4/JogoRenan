using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capy : MonoBehaviour
{
    public int caValue;
   


    private void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D CO)
    {
        if (CO.gameObject.tag == "Player")
        {
            gamecontroller.instance.UpdateCa(caValue);
            Destroy(gameObject, 0.1f);
        }
    }
}
