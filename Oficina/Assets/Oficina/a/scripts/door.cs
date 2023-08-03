using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D d)
    {
        if (d.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(3); 
        }
    }
}

