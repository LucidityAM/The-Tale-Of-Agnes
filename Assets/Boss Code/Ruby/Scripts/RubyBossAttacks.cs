using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class RubyBossAttacks : MonoBehaviour
{
    public GameObject bullet;
    public GameObject basicBullet;
    public GameObject Target;
    public GameObject fistBullet;
    public GameObject leftBullet;
    public GameObject rightBullet;
    public Vector3 lastPlrPosition;
    public int bulletAmount = 0;

    public Collider2D DTrigger;
    public Collider2D UTrigger;
    public Collider2D LTrigger;
    public Collider2D RTrigger;


    public void Update()
    {
        if(BossHealthHolder.bossHealth <= 0)
        {
            if(GameManager.confidenceLevel < 0f)
            {
                GameManager.confidenceLevel = 0f;
            }
            DTrigger.isTrigger = true;
            UTrigger.isTrigger = true;
            LTrigger.isTrigger = false;
            RTrigger.isTrigger = false;
            Destroy(gameObject);
        }
    }

    public void StartBossFight()
    {
        //StartCoroutine("Phase1Normal", 20);
        StartCoroutine("Phase1Special", 20);
        BossHealthHolder.bossHealth = 1;
    }

    IEnumerator Phase1Normal(int time)
    {
        DTrigger.isTrigger = false;
        UTrigger.isTrigger = false;
        LTrigger.isTrigger = false;
        RTrigger.isTrigger = false;
        yield return new WaitForSeconds(3.0f);
        while (time > 0)
        {
            time -= 1;
            basicBullet = Instantiate(bullet, new Vector3(97.81f, -16.22f, 0), Quaternion.identity);
            lastPlrPosition = new Vector3(Target.transform.position.x, Target.transform.position.y, Target.transform.position.z);
            basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-25, 0);
            yield return new WaitForSeconds(1.0f);
        }
        //StartCoroutine("Phase1Special", 20);
        StopCoroutine("Phase1Normal");
    }

    IEnumerator Phase1Special(int time)
    {
        DTrigger.isTrigger = false;
        UTrigger.isTrigger = false;
        LTrigger.isTrigger = false;
        RTrigger.isTrigger = false;
        yield return new WaitForSeconds(3.0f);
        while (time > 0)
        {
            time -= 1;
            fistBullet.GetComponent<SpriteRenderer>().flipY = true;
            leftBullet = Instantiate(fistBullet, new Vector3(65f, Target.transform.position.y, 0), new Quaternion(0, 0, 180, 0));
            fistBullet.GetComponent<SpriteRenderer>().flipY = false;
            rightBullet = Instantiate(fistBullet, new Vector3(93f, Target.transform.position.y, 0), Quaternion.identity);
            leftBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(20f, 0);
            rightBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0);
            yield return new WaitForSeconds(1.5f);
        }
        //StartCoroutine("Phase2Normal", 20);
        StartCoroutine("Phase2Special", 20);
        StopCoroutine("Phase1Special");
    }

    IEnumerator Phase2Normal(int time)
    {
        yield return new WaitForSeconds(5.0f);
        while(time > 0)
        {
            time -= 1;
        }
        StartCoroutine("Phase2Special", 20);
        StopCoroutine("Phase2Normal");
    }

    IEnumerator Phase2Special(int time)
    {
        yield return new WaitForSeconds(3.0f);
        while (time > 0)
        {
            time -= 1;
            for (float x = 65f; x <= 104f; x += 4.5f)
            {
                Vector3 posSwordBullet = new Vector3(x, -25, 0);
                basicBullet = Instantiate(bullet, posSwordBullet, bullet.transform.rotation);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 15);
            }
            yield return new WaitForSeconds(1.0f);
            time -= 1;
            for (float x = 65f; x <= 104f; x += 5.5f)
            {
                Vector3 posSwordBullet = new Vector3(x, -25, 0);
                basicBullet = Instantiate(bullet, posSwordBullet, bullet.transform.rotation);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 15);
            }
            yield return new WaitForSeconds(1.0f);
        }
        DTrigger.isTrigger = false;
        UTrigger.isTrigger = false;
        LTrigger.isTrigger = false;
        RTrigger.isTrigger = false;
        StartCoroutine("Phase2Normal2", 20);
        StopCoroutine("Phase2Special");
    }

    IEnumerator Phase2Normal2(int time)
    {
        yield return new WaitForSeconds(5.0f);
        while (time > 0)
        {
            time -= 1;
        }
        StartCoroutine("Phase1Special2", 10);
        StopCoroutine("Phase2Normal2");
    }

    IEnumerator Phase1Special2(int time)
    {
        DTrigger.isTrigger = false;
        UTrigger.isTrigger = false;
        LTrigger.isTrigger = false;
        RTrigger.isTrigger = false;
        yield return new WaitForSeconds(3.0f);
        while (time > 0)
        {
            time -= 1;
            fistBullet.GetComponent<SpriteRenderer>().flipY = true;
            leftBullet = Instantiate(fistBullet, new Vector3(65f, Target.transform.position.y, 0), new Quaternion(0, 0, 180, 0));
            fistBullet.GetComponent<SpriteRenderer>().flipY = false;
            rightBullet = Instantiate(fistBullet, new Vector3(93f, Target.transform.position.y, 0), Quaternion.identity);
            leftBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(20f, 0);
            rightBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0);
            yield return new WaitForSeconds(1.5f);
        }
        //StartCoroutine("Phase2Normal", 20);
        StartCoroutine("Phase2Special2", 10);
        StopCoroutine("Phase1Special2");
    }
    IEnumerator Phase2Special2(int time)
    {
        yield return new WaitForSeconds(3.0f);
        while (time > 0)
        {
            time -= 1;
            for (float x = 65f; x <= 104f; x += 3.5f)
            {
                Vector3 posSwordBullet = new Vector3(x, -25, 0);
                basicBullet = Instantiate(bullet, posSwordBullet, bullet.transform.rotation);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 12);
            }
            yield return new WaitForSeconds(1.0f);
            time -= 1;
            for (float x = 65f; x <= 104f; x += 4.5f)
            {
                Vector3 posSwordBullet = new Vector3(x, -25, 0);
                basicBullet = Instantiate(bullet, posSwordBullet, bullet.transform.rotation);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 12);
            }
            yield return new WaitForSeconds(1.0f);
        }
        DTrigger.isTrigger = true;
        UTrigger.isTrigger = true;
        LTrigger.isTrigger = false;
        RTrigger.isTrigger = false;
        StopCoroutine("Phase2Special2");
        StartCoroutine("Phase1Special", 20);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy Bullet"))
        {
            Destroy(collision.otherCollider.gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("room"))
        {
            Destroy(collision.gameObject);
        }
    }
}
