using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GrazeSystem : MonoBehaviour
{
    public BoxCollider2D grazeHitbox;
    private CapsuleCollider2D realHitbox;

    public SpriteRenderer graze;
    // Start is called before the first frame update
    void Start()
    {
        realHitbox = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy Bullet" && collision.IsTouching(grazeHitbox) && PlayerStats.resolve == 1)
        {
            GameManager.confidenceLevel += 0.1f;
        }
        else if (collision.gameObject.tag == "Enemy Bullet" && collision.IsTouching(grazeHitbox) && PlayerStats.resolve == 2)
        {
            GameManager.confidenceLevel += 0.12f;
        }
        else if (collision.gameObject.tag == "Enemy Bullet" && collision.IsTouching(grazeHitbox) && PlayerStats.resolve == 3)
        {
            GameManager.confidenceLevel += 0.14f;
        }
        else if (collision.gameObject.tag == "Enemy Bullet" && collision.IsTouching(grazeHitbox) && PlayerStats.resolve == 10)
        {
            GameManager.confidenceLevel += 0.14f;
        }
        
        if(collision.gameObject.CompareTag("Enemy Bullet") && collision.IsTouching(grazeHitbox))
        {
            graze.enabled = true;

            Invoke("GrazeDisable", .3f);
        }
        else if (collision.IsTouching(realHitbox))
        {
            GrazeDisable();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy Bullet" && collision.otherCollider == realHitbox && PlayerStats.resolve == 1)
        {
            GameManager.confidenceLevel -= 0.1f;
            GameManager.confidenceLevel -= 0.3f;
        }
        else if (collision.gameObject.tag == "Enemy Bullet" && collision.otherCollider == realHitbox && PlayerStats.resolve == 2)
        {
            GameManager.confidenceLevel -= 0.08f;
            GameManager.confidenceLevel -= 0.28f;
        }
        else if (collision.gameObject.tag == "Enemy Bullet" && collision.otherCollider == realHitbox && PlayerStats.resolve == 3)
        {
            GameManager.confidenceLevel -= 0.06f;
            GameManager.confidenceLevel -= 0.26f;
        }
        else if (collision.gameObject.tag == "Enemy Bullet" && collision.otherCollider == realHitbox && PlayerStats.resolve == 10)
        {
            GameManager.confidenceLevel -= 0.02f;
            GameManager.confidenceLevel -= 0.2f;
        }
        if (collision.gameObject.tag == "Enemy" && collision.otherCollider == realHitbox && PlayerStats.resolve == 1)
        {
            GameManager.confidenceLevel -= 0.1f;
            GameManager.confidenceLevel -= 0.5f;
        }
        else if (collision.gameObject.tag == "Enemy" && collision.otherCollider == realHitbox && PlayerStats.resolve == 2)
        {
            GameManager.confidenceLevel -= 0.08f;
            GameManager.confidenceLevel -= 0.48f;
        }
        else if (collision.gameObject.tag == "Enemy" && collision.otherCollider == realHitbox && PlayerStats.resolve == 3)
        {
            GameManager.confidenceLevel -= 0.06f;
            GameManager.confidenceLevel -= 0.46f;
        }
        else if (collision.gameObject.tag == "Enemy" && collision.otherCollider == realHitbox && PlayerStats.resolve == 10)
        {
            GameManager.confidenceLevel -= 0.2f;
            GameManager.confidenceLevel -= 0.38f;
        }
    }


    public void GrazeDisable()
    {
        graze.enabled = false;
    }
}

