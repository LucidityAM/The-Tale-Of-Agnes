using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class BossAttacks : MonoBehaviour
{
    public GameObject bullet;
    public GameObject basicBullet;
    public GameObject Target;
    public GameObject followSwordBullet;
    public GameObject fistBullet;
    public GameObject leftBullet;
    public GameObject rightBullet;
    public GameObject swordBullet;

    public GameObject cutlass;

    public Transform spawnLoc;

    public Vector3 lastPlrPosition;
    public int bulletAmount = 0;
    private float movespeed = 10f;
    public static bool defeatedRuby = false;
    public static bool defeatedStripes = false;
    private bool hasGenerated = false;

    public Collider2D DTrigger;
    public Collider2D UTrigger;
    public Collider2D LTrigger;
    public Collider2D RTrigger;

    public List<GameObject> bullets = new List<GameObject>();


    public void Update()
    {
        if (BossHealthHolder.bossHealth <= 0)
        {
            if (GameManager.confidenceLevel < 0f)
            {
                GameManager.confidenceLevel = 0f;
            }
            if (defeatedRuby == false && defeatedStripes == false)
            {
                defeatedRuby = true;
                StopAllCoroutines();
                Destroy(gameObject);
            }
            else if (defeatedRuby == true && defeatedStripes == false)
            {
                defeatedStripes = true;
                GameObject sCutlass = Instantiate(cutlass, spawnLoc.transform.position, Quaternion.identity);
                Destroy(followSwordBullet);
                StopAllCoroutines();
                Destroy(gameObject);
            }
            else
            {
                DestroyImmediate(followSwordBullet, true);
                StopAllCoroutines();
                Destroy(gameObject);
            }
        }
    }

    public void StartRubyBossFight()
    {
        StartCoroutine("Phase1RubySpecial", 20);
        DTrigger.isTrigger = false;
        UTrigger.isTrigger = false;
        LTrigger.isTrigger = false;
        RTrigger.isTrigger = false;
        BossHealthHolder.bossHealth = 350;
    }

    public void StartStripesBossFight()
    {
        
        StartCoroutine("Phase1StripesSpecial", 20);
        DTrigger.isTrigger = false;
        UTrigger.isTrigger = false;
        LTrigger.isTrigger = false;
        RTrigger.isTrigger = false;
        BossHealthHolder.bossHealth = 500;
    }

    public void StartDragonBossFight()
    {
        StartCoroutine("Phase1DragonSpecial", 20);
        DTrigger.isTrigger = false;
        UTrigger.isTrigger = false;
        LTrigger.isTrigger = false;
        RTrigger.isTrigger = false;
        BossHealthHolder.bossHealth = 800;
    }

    IEnumerator Phase1RubySpecial(int time)
    {
        yield return new WaitForSeconds(3.0f);
        while (time > 0)
        {
            time -= 1;
            fistBullet.GetComponent<SpriteRenderer>().flipY = true;
            leftBullet = Instantiate(fistBullet, new Vector3(67f, Target.transform.position.y, 0), new Quaternion(0, 0, 180, 0));
            bullets.Add(leftBullet);
            fistBullet.GetComponent<SpriteRenderer>().flipY = false;
            rightBullet = Instantiate(fistBullet, new Vector3(93f, Target.transform.position.y, 0), Quaternion.identity);
            bullets.Add(rightBullet);
            leftBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(20f, 0);
            rightBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0);
            yield return new WaitForSeconds(1.5f);
        }
        StartCoroutine("Phase2RubySpecial", 20);
        StopCoroutine("Phase1RubySpecial");
    }

    IEnumerator Phase2RubySpecial(int time)
    {
        yield return new WaitForSeconds(3.0f);
        while (time > 0)
        {
            time -= 1;
            for (float x = 65f; x <= 104f; x += 4.5f)
            {
                Vector3 posSwordBullet = new Vector3(x, -25, 0);
                basicBullet = Instantiate(bullet, posSwordBullet, bullet.transform.rotation);
                bullets.Add(basicBullet);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 15);
            }
            yield return new WaitForSeconds(1.0f);
            time -= 1;
            for (float x = 65f; x <= 104f; x += 5.5f)
            {
                Vector3 posSwordBullet = new Vector3(x, -25, 0);
                basicBullet = Instantiate(bullet, posSwordBullet, bullet.transform.rotation);
                bullets.Add(basicBullet);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 15);
            }
            yield return new WaitForSeconds(1.0f);
        }
        StartCoroutine("Phase1RubySpecial", 20);
        StopCoroutine("Phase2RubySpecial");
    }

    IEnumerator Phase1StripesSpecial(int time)
    {
        yield return new WaitForSeconds(3.0f);
        while (time > 0)
        {
            time -= 1;
            for (int y = 52; y >= 25; y -= 6)
            {
                Vector3 posSwordBullet = new Vector3(-84, y, 0);
                basicBullet = Instantiate(swordBullet, posSwordBullet, Quaternion.identity);
                basicBullet.transform.Rotate(0f, 0f, -90f, Space.World);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(13, 0);
            }
            yield return new WaitForSeconds(.6f);
            for (int y = 50; y >= 24f; y -= 6)
            {
                Vector3 posSwordBullet = new Vector3(-66, y, 0);
                basicBullet = Instantiate(swordBullet, posSwordBullet, Quaternion.identity);
                basicBullet.transform.Rotate(0f, 0f, 90f, Space.World);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-13, 0);
            }
            yield return new WaitForSeconds(1.0f);
        }
        StartCoroutine("Phase2StripesSpecial", 15);
        StopCoroutine("Phase1StripesSpecial");
    }

    IEnumerator Phase2StripesSpecial(int time)
    {
        yield return new WaitForSeconds(3.0f);
        GenerateBullet();
        while (time > 0)
        {
            time -= 1;
            Vector3 plrLastPos = new Vector3(Target.transform.position.x, Target.transform.position.y, Target.transform.position.z);
            followSwordBullet.transform.position = Vector3.Lerp(followSwordBullet.transform.position, plrLastPos, movespeed * Time.deltaTime);
            Vector3 lookPos = followSwordBullet.transform.position - Target.transform.position;
            float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
            followSwordBullet.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            movespeed += 1.5f;
            yield return new WaitForSeconds(1.0f);
        }
        followSwordBullet.gameObject.SetActive(false);
        StartCoroutine("Phase1StripesSpecial", 20);
        StopCoroutine("Phase2StripesSpecial");
    }

    IEnumerator Phase1DragonSpecial(int time)
    {
        yield return new WaitForSeconds(3.0f);
        while (time > 0)
        {
            time -= 1;
            for (float x = -11f; x <= 12f; x += 4f)
            {
                Vector3 posSwordBullet = new Vector3(x, 50, 16);
                basicBullet = Instantiate(bullet, posSwordBullet, bullet.transform.rotation);
                basicBullet.transform.Rotate(0f, 0f, 90f, Space.World);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -10);
            }
            yield return new WaitForSeconds(3.0f);
            time -= 1;
            for (float x = -9f; x <= 11f; x += 4f)
            {
                Vector3 posSwordBullet = new Vector3(x, 25, 16);
                basicBullet = Instantiate(bullet, posSwordBullet, bullet.transform.rotation);
                basicBullet.transform.Rotate(0f, 0f, -90f, Space.World);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
            }
            yield return new WaitForSeconds(3.0f);
            time -= 1;
            for (int y = 54; y >= 24; y -= 6)
            {
                Vector3 posSwordBullet = new Vector3(-10, y, 16);
                basicBullet = Instantiate(bullet, posSwordBullet, Quaternion.identity);
                basicBullet.transform.Rotate(0f, 0f, 180f, Space.World);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
            }
            yield return new WaitForSeconds(2.2f);
            time -= 1;
            for (int y = 51; y >= 27f; y -= 6)
            {
                Vector3 posSwordBullet = new Vector3(7.5f, y, 16);
                basicBullet = Instantiate(bullet, posSwordBullet, Quaternion.identity);
                basicBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);
            }
            yield return new WaitForSeconds(2.2f);
        }
        StartCoroutine("Phase2DragonSpecial", 20);
        StopCoroutine("Phase1DragonSpecial");
    }

    IEnumerator Phase2DragonSpecial(int time)
    {
        yield return new WaitForSeconds(3.0f);
        if (hasGenerated == false)
        {
            GenerateDragonBullet();
            hasGenerated = true;
        }
        followSwordBullet.gameObject.SetActive(true);
        while (time > 0)
        {
            time -= 1;
            bullet.GetComponent<SpriteRenderer>().flipY = true;
            leftBullet = Instantiate(bullet, new Vector3(-11f, Target.transform.position.y, 16), new Quaternion(0, 0, 180, 0));
            bullets.Add(leftBullet);
            bullet.GetComponent<SpriteRenderer>().flipY = false;
            rightBullet = Instantiate(bullet, new Vector3(11f, Target.transform.position.y, 16), Quaternion.identity);
            bullets.Add(rightBullet);
            leftBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0);
            rightBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0);
            yield return new WaitForSeconds(1.5f);
            StartCoroutine("Phase2DragonSpecial1", 1);
            time -= 1;
        }
        followSwordBullet.gameObject.SetActive(false);
        StartCoroutine("Phase1DragonSpecial", 20);
        StopCoroutine("Phase2DragonSpecial");
    }

    IEnumerator Phase2DragonSpecial1(int time)
    {
        while (time > 0)
        {
            Vector3 plrLastPos = new Vector3(Target.transform.position.x, Target.transform.position.y, 16f);
            followSwordBullet.transform.position = Vector3.Lerp(followSwordBullet.transform.position, plrLastPos, movespeed * Time.deltaTime);
            Vector3 lookPos = followSwordBullet.transform.position - Target.transform.position;
            float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
            followSwordBullet.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            movespeed += .5f;
            yield return new WaitForSeconds(1.5f);
            time -= 1;
        }
        StopCoroutine("Phase2DragonSpecial1");
    }

    private void GenerateBullet()
    {
        Vector3 posSwordBullet = new Vector3(-75, 31f, 16);
        followSwordBullet = Instantiate(followSwordBullet, posSwordBullet, Quaternion.identity);
    }

    private void GenerateDragonBullet()
    {
        Vector3 posSwordBullet = new Vector3(0, 26, 0);
        followSwordBullet.gameObject.SetActive(true);
        followSwordBullet = Instantiate(followSwordBullet, posSwordBullet, Quaternion.identity);
    }
}
