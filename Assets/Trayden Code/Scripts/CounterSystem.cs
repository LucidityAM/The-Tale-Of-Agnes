using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterSystem : MonoBehaviour
{
    public GameObject Sword;
    private bool hasHit = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy Bullet" && hasHit == false)
        {
            Destroy(collision.gameObject);
            hasHit = true;
            Sword.GetComponent<BoxCollider2D>().enabled = false;
            GameManager.confidenceLevel += 0.3f;
            StartCoroutine(Cooldown());

        }
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SetActive(false);
            GameManager.confidenceLevel += 0.5f;
        }
    }

    public IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(3f);

        hasHit = false;
        Sword.GetComponent<BoxCollider2D>().enabled = true;

    }
}
