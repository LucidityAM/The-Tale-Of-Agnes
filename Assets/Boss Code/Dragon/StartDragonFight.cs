using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDragonFight : MonoBehaviour
{
    public BossAttacks bossAttacks;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(collision.gameObject);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            bossAttacks.StartDragonBossFight();
        }
    }
}
