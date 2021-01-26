using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdle : MonoBehaviour
{
    public Transform target; //target = player
    SpriteRenderer sr;
    public bool destroy;
    public bool stop;

    AudioSource enemyHit;
    private void Start()
    {
        destroy = false;
        sr = gameObject.GetComponent<SpriteRenderer>();
        enemyHit = gameObject.GetComponent<AudioSource>();
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
        if (collision.gameObject.tag == "sword")
        {
            sr.color = EnemyStats.damage;
            Invoke("DamageColorNormal", .2f);
        }
        if (collision.gameObject.tag == "player")
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
