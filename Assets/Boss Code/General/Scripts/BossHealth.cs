using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public SpriteRenderer sr;

    public Slider bossHealth;

    public int health;

    AudioSource bossHit;
    public void Start()
    {
        BossHealthHolder.bossHealth = health;
        bossHit = GetComponent<AudioSource>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        bossHealth.maxValue = BossHealthHolder.bossHealth;
    }

    private void OnCollsionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            sr.color = EnemyStats.damage;
            Destroy(collision.gameObject);
            Invoke("DamageColorNormal", .2f);
            bossHit.Play();
        }
    }

    private void DamageColorNormal()
    {
        sr.color = new Color(1, 1, 1);
    }

    public void Update()
    {
        bossHealth.value = BossHealthHolder.bossHealth;
    }
}
