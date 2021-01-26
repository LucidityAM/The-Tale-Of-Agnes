using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public RandomItemDrops rI;

    public SpriteRenderer spider;
    public SpriteRenderer slime;
    public SpriteRenderer slime1;
    public SpriteRenderer bat;
    public SpriteRenderer bat1;
    public SpriteRenderer boss1;

    public SpriteRenderer player;

    public AudioSource swordHit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.CompareTag("PlayerBullet"))
        {
            if (collision.gameObject.tag == "Enemy Bullet")
            {
                Destroy(gameObject);
            }

            if (collision.gameObject.CompareTag("Spider"))
            {
                spider = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth1 -= PlayerStats.strength * PlayerStats.baseAttack;
                Destroy(this.gameObject);
            }
            if (EnemyStats.enemyHealth1 <= 0 && collision.gameObject.CompareTag("Spider"))
            {
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Spider").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth1 = EnemyStats.enemyMaxHealth1;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
                Destroy(gameObject);
            }

            if (collision.gameObject.CompareTag("Slime"))
            {
                slime = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth2 -= PlayerStats.strength * PlayerStats.baseAttack;
                Destroy(this.gameObject);
            }
            if (EnemyStats.enemyHealth2 <= 0 && collision.gameObject.CompareTag("Slime"))
            {
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Slime").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth2 = EnemyStats.enemyMaxHealth2;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
                Destroy(gameObject);
            }

            if (collision.gameObject.CompareTag("Slime1"))
            {
                slime = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth5 -= PlayerStats.strength * PlayerStats.baseAttack;
                Destroy(this.gameObject);
            }
            if (EnemyStats.enemyHealth5 <= 0 && collision.gameObject.CompareTag("Slime1"))
            {
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Slime1").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth5 = EnemyStats.enemyMaxHealth5;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
                Destroy(gameObject);
            }

            if (collision.gameObject.CompareTag("Bat"))
            {
                bat = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth3 -= PlayerStats.strength * PlayerStats.baseAttack;
                Destroy(this.gameObject);
            }
            if (EnemyStats.enemyHealth3 <= 0 && collision.gameObject.CompareTag("Bat"))
            {
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Bat").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth3 = EnemyStats.enemyMaxHealth3;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
                Destroy(gameObject);
            }

            if (collision.gameObject.CompareTag("Bat1"))
            {
                bat1 = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth4 -= PlayerStats.strength * PlayerStats.baseAttack;
                Destroy(this.gameObject);
            }
            if (EnemyStats.enemyHealth4 <= 0 && collision.gameObject.CompareTag("Bat1"))
            {
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Bat1").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth4 = EnemyStats.enemyMaxHealth4;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
                Destroy(gameObject);
            }

            if (collision.gameObject.CompareTag("Boss1"))
            {
                boss1 = collision.gameObject.GetComponent<SpriteRenderer>();
                BossHealthHolder.bossHealth -= PlayerStats.strength * PlayerStats.baseAttack;
                Destroy(this.gameObject);
            }
        }

        if (gameObject.CompareTag("sword"))
        {

            EnemyStats.isHit = true;

            if (collision.gameObject.CompareTag("Spider"))
            {
                swordHit.Play();
                spider = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth1 -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
                spider.color = EnemyStats.damage;
                Invoke("DamageColorNormal", .2f);
            }
            if (EnemyStats.enemyHealth1 <= 0 && collision.gameObject.CompareTag("Spider"))
            {
                swordHit.Play();
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Spider").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth1 = EnemyStats.enemyMaxHealth1;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
               
            }

            if (collision.gameObject.CompareTag("Slime"))
            {
                swordHit.Play();
                slime = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth2 -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
                slime.color = EnemyStats.damage;
                Invoke("DamageColorNormal", .2f);
            }
            if (EnemyStats.enemyHealth2 <= 0 && collision.gameObject.CompareTag("Slime"))
            {
                swordHit.Play();
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Slime").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth2 = EnemyStats.enemyMaxHealth2;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
                
            }

            if (collision.gameObject.CompareTag("Slime1"))
            {
                swordHit.Play();
                slime = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth5 -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
                slime.color = EnemyStats.damage;
                Invoke("DamageColorNormal", .2f);
            }
            if (EnemyStats.enemyHealth5 <= 0 && collision.gameObject.CompareTag("Slime1"))
            {
                swordHit.Play();
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Slime1").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth5 = EnemyStats.enemyMaxHealth5;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
            }

            if (collision.gameObject.CompareTag("Bat"))
            {
                swordHit.Play();
                bat = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth3 -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
                bat.color = EnemyStats.damage;
                Invoke("DamageColorNormal", .2f);
            }
            if (EnemyStats.enemyHealth3 <= 0 && collision.gameObject.CompareTag("Bat"))
            {
                swordHit.Play();
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Bat").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth3 = EnemyStats.enemyMaxHealth3;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
                
            }

            if (collision.gameObject.CompareTag("Bat1"))
            {
                swordHit.Play();
                bat1 = collision.gameObject.GetComponent<SpriteRenderer>();
                EnemyStats.enemyHealth4 -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
                bat1.color = EnemyStats.damage;
                Invoke("DamageColorNormal", .2f);
            }
            if (EnemyStats.enemyHealth4 <= 0 && collision.gameObject.CompareTag("Bat1"))
            {
                swordHit.Play();
                Enemy.stop = false;
                rI = GameObject.FindWithTag("Bat1").GetComponent<RandomItemDrops>();
                rI.RandomDrop();
                EnemyStats.enemyHealth4 = EnemyStats.enemyMaxHealth4;
                Destroy(collision.gameObject);
                GameManager.confidenceLevel += .7f;
                
            }


            if (collision.gameObject.CompareTag("Boss1"))
            {
                swordHit.Play();
                boss1 = collision.gameObject.GetComponent<SpriteRenderer>();
                BossHealthHolder.bossHealth -= PlayerStats.strength * PlayerStats.baseAttack * 1.5f;
                boss1.color = EnemyStats.damage;
                Invoke("DamageColorNormal", .2f);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Invoke("DamageColorNormal", .2f);
        EnemyStats.isHit = false;
    }

    private void DamageColorNormal()
    {
        if(spider != null)
        {
            spider.color = new Color(1, 1, 1);
        }

        if (slime != null)
        {
            slime.color = new Color(1, 1, 1);
        }

        if (slime1 != null)
        {
            slime.color = new Color(1, 1, 1);
        }

        if (bat != null)
        {
            bat.color = new Color(1, 1, 1);
        }        
        
        if (bat1 != null)
        {
            bat1.color = new Color(1, 1, 1);
        }

        if (boss1 != null)
        {
            boss1.color = new Color(1, 1, 1);
        }
    }
}
