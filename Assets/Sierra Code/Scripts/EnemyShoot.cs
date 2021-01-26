using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform target; //target = player
    public Transform firePoint;

    public GameObject bullet;

    public float fireRate = 3000f; //Fire every 3 seconds
    public float shootingPower = 2f;
    private float shootingTime;

    public AudioSource Spider;
    public AudioSource Slime;
    public AudioSource Bat;

    public void Start()
    {
        if (gameObject.tag == "SpiderS")
        {
            Spider = gameObject.GetComponent<AudioSource>();
            StartCoroutine(SpiderFire());
        }
        if (gameObject.tag == "SlimeS")
        {
            Slime = gameObject.GetComponent<AudioSource>();
            SlimeFire();
        }
        if (gameObject.tag == "BatS")
        {
            Bat = gameObject.GetComponent<AudioSource>();
            BatFire();
        }
    }

    private void Update()
    {
        transform.right = transform.position - target.position;
        if(gameObject.tag == "SpiderS")
        {
           StartCoroutine(SpiderFire());
        }
        if (gameObject.tag == "SlimeS")
        {
            SlimeFire();
        }
        if(gameObject.tag == "BatS")
        {
            BatFire();
        }
    }


    private IEnumerator SpiderFire()
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000;

            Spider.Play();

            Vector3 myPos = new Vector3(firePoint.position.x , firePoint.position.y, firePoint.position.z);

            GameObject projectile = Instantiate(bullet, myPos, transform.rotation);
            Vector2 direction = (Vector3)target.position - myPos;
            projectile.GetComponent<Rigidbody2D>().velocity = direction * shootingPower;

            yield return new WaitForSeconds(.3f);

            Spider.Play();

            GameObject projectile1 = Instantiate(bullet, myPos, transform.rotation);
            Vector2 direction1 = (Vector3)target.position- myPos;
            projectile1.GetComponent<Rigidbody2D>().velocity = direction1 * shootingPower;
        }
    }
    private void SlimeFire()
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000;

            Slime.Play();

            Vector3 myPos = new Vector3(firePoint.position.x, firePoint.position.y, firePoint.position.z);
            GameObject projectile = Instantiate(bullet, myPos, transform.rotation);
            Vector2 direction = (Vector3)target.position - myPos;
            projectile.GetComponent<Rigidbody2D>().velocity = direction * shootingPower;
        }
    }
    private void BatFire()
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1500;

            Bat.Play();

            Vector3 myPos = new Vector3(firePoint.position.x, firePoint.position.y, firePoint.position.z);
            GameObject projectile = Instantiate(bullet, myPos, transform.rotation);
            Vector2 direction = (Vector3)target.position - myPos;
            projectile.GetComponent<Rigidbody2D>().velocity = direction * shootingPower;
        }
       
    }
}
