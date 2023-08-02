using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public float SPEED;
    public float walkTime;

    public float timer;
    public bool walkRight;

    public int health;
    public int damage = 1;

    private Rigidbody2D RIG;
    // Start is called before the first frame update
    void Start()
    {
        RIG = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer >= walkTime)
        {
            walkRight = !walkRight;
            timer = 0f;
        }

        if (walkRight)
        {
            transform.eulerAngles = new Vector2(0, 180);
            RIG.velocity = Vector2.right * SPEED;
        }

        else
        {
            transform.eulerAngles = new Vector2(0, 0);
            RIG.velocity = Vector2.left * SPEED;
        }
    }

    public void Damage(int D)
    {
        health -= D;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D CO)
    {
        if (CO.gameObject.tag == "Player")
        {
            CO.gameObject.GetComponent<Player>().Damage(damage);
        }
    }
}
