using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target; //target = player
    SpriteRenderer sr;
    private float movespeed = 2.8f;
    public bool destroy;
    public static bool stop;

    AudioSource enemyHit;
    private void Start()
    {
        destroy = false;
        sr = gameObject.GetComponent<SpriteRenderer>();
        enemyHit = gameObject.GetComponent<AudioSource>();  
    }
    private void Update()
    {
        if (stop == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, movespeed * Time.deltaTime);
        }
        else
        {
            transform.position = transform.position;
        }

        if(target.position.x - transform.position.x < 0)
        {
            sr.flipX = false;
        }
        else
        {
            sr.flipX = true;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "PlayerBullet")
        {
            enemyHit.Play();

            sr.color = EnemyStats.damage;            

            Destroy(collision.gameObject);

            Invoke("DamageColorNormal", .2f);
        }
        if (collision.gameObject.name == "Agnes")
        {
            stop = true;
        } 
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        stop = false;
    }

    private void DamageColorNormal()
    {
        sr.color = new Color(1, 1, 1);
    }
}