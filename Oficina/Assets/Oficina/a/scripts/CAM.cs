using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAM : MonoBehaviour
{

    private Transform player;

    public float smooth;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player.position.x >= -5.0 && player.position.x < 659.0)
        {
            Vector3 following = new Vector3(player.position.x,player.position.y,transform.position.z);

            transform.position = Vector3.Lerp(transform.position, following, smooth * Time.deltaTime);
        
        }
        
        /*if (player.position.x < 285)
        {
            Vector3 following = new Vector3(player.position.x, player.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, following, smooth * Time.deltaTime);
        
        }*/
      
        
    }
}
