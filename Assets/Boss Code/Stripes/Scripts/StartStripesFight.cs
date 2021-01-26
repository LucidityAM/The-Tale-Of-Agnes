using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStripesFight : MonoBehaviour
{
    public BossAttacks bossAttacks;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(collision.gameObject);
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            bossAttacks.StartStripesBossFight();
        }
    }
}
