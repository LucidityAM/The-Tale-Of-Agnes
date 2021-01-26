using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootandStabLevel2 : MonoBehaviour
{
    Animator anim;

    public Animator stab;

    public Transform swordTip;
    public GameObject bulletPrefab;
    public float fireRate = 1000f; //Fire every 1 seconds
    public float shootingPower = 2f;
    private float shootingTime;

    private bool isShooting;
    private bool isStabbing;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) & isShooting == false)
        {
            isStabbing = true;
        }
        else
        {
            isStabbing = false;
        }



        if (Input.GetKey(KeyCode.DownArrow) && isStabbing == false)
        {
            anim.SetBool("isSwingingDown", true);
            Shoot();
            isShooting = true;
        }
        else
        {
            anim.SetBool("isSwingingDown", false);
            isShooting = false;
        }

        if (Input.GetKey(KeyCode.RightArrow) && isStabbing == false)
        {
            anim.SetBool("isSwingingRight", true);
            Shoot();
            isShooting = true;
        }
        else
        {
            anim.SetBool("isSwingingRight", false);
            isShooting = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && isStabbing == false)
        {
            anim.SetBool("isSwingingLeft", true);
            Shoot();
            isShooting = true;
        }
        else
        {
            anim.SetBool("isSwingingLeft", false);
            isShooting = false;
        }

        if (Input.GetKey(KeyCode.UpArrow) && isStabbing == false)
        {
            anim.SetBool("isSwingingUp", true);
            Shoot();
            isShooting = true;
        }
        else
        {
            anim.SetBool("isSwingingUp", false);
            isShooting = false;
        }

        if (Input.GetKey(KeyCode.UpArrow) && isStabbing == true)
        {
            stab.SetBool("stabUp", true);
        }
        else
        {
            stab.SetBool("stabUp", false);
        }

        if (Input.GetKey(KeyCode.DownArrow) && isStabbing == true)
        {
            stab.SetBool("stabDown", true);
        }
        else
        {
            stab.SetBool("stabDown", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && isStabbing == true)
        {
            stab.SetBool("stabLeft", true);
        }
        else
        {
            stab.SetBool("stabLeft", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) && isStabbing == true)
        {
            stab.SetBool("stabRight", true);
        }
        else
        {
            stab.SetBool("stabRight", false);
        }
    }

    private void Shoot()
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000 / PlayerStats.attackRate;
            GameObject bullet = Instantiate(bulletPrefab, swordTip.position, swordTip.rotation);
            Rigidbody2D rb2 = bullet.GetComponent<Rigidbody2D>();
            rb2.AddForce(swordTip.up * shootingPower, ForceMode2D.Impulse);
        }
    }
}