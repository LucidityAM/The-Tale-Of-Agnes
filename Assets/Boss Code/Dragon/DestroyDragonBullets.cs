using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDragonBullets : MonoBehaviour
{
    public SpriteRenderer sr;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player") || collision.gameObject.CompareTag("room") || collision.gameObject.CompareTag("Enemy Bullet") || collision.gameObject.CompareTag("Boss1") && collision.gameObject.name != "FollowDragonBullet")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("player") || collider.gameObject.CompareTag("room") || collider.gameObject.CompareTag("Enemy Bullet") && collider.gameObject.name != "FollowDragonBullet")
        {
            Destroy(gameObject);
        }
    }
}
