using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemySword : MonoBehaviour
{
    public Collider2D coll;

    private void OnCollisonEnter2D(Collision2D collision)
    {
        Debug.Log("HITTTT");

        if (collision.gameObject.CompareTag("Spider"))
        {
            EnemyStats.enemyHealth1 -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
        }
        if (EnemyStats.enemyHealth1 <= 0 && collision.gameObject.CompareTag("Spider"))
        {
            Destroy(collision.gameObject);
            GameManager.confidenceLevel += 0.5f;
            EnemyStats.enemyHealth1 = EnemyStats.enemyMaxHealth1;
        }

        if (collision.gameObject.CompareTag("Slime"))
        {
            EnemyStats.enemyHealth2 -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
        }
        if (EnemyStats.enemyHealth2 <= 0 && collision.gameObject.CompareTag("Slime"))
        {
            Destroy(collision.gameObject);
            GameManager.confidenceLevel += 0.5f;
            EnemyStats.enemyHealth2 = EnemyStats.enemyMaxHealth2;
        }

        if (collision.gameObject.CompareTag("Bat"))
        {
            EnemyStats.enemyHealth3 -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
        }
        if (EnemyStats.enemyHealth3 <= 0 && collision.gameObject.CompareTag("Bat"))
        {
            Destroy(collision.gameObject);
            GameManager.confidenceLevel += 0.5f;
            EnemyStats.enemyHealth3 = EnemyStats.enemyMaxHealth3;
        }
        
        if (collision.gameObject.CompareTag("Bat1"))
        {
            EnemyStats.enemyHealth4 -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
        }
        if (EnemyStats.enemyHealth4 <= 0 && collision.gameObject.CompareTag("Bat1"))
        {
            Destroy(collision.gameObject);
            GameManager.confidenceLevel += 0.5f;
            EnemyStats.enemyHealth4 = EnemyStats.enemyMaxHealth4;
        }


    }
}
