using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementLevel2 : MonoBehaviour
{
    public bool isStabbing;
    
    public Vector2 movement;

    public float hf = 0.0f;
    public float vf = 0.0f;
    public float movementSpeed = 1f;

    SpriteRenderer sr;
    Animator anim;  
    Rigidbody2D rb2;

    public GameObject sword;
    public GameObject swordSprite;

    public bool isReset = false;

    public AudioSource hit;
    public AudioSource walk;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();


        SceneLoading.Level1 = true;

        if(PlayerStats.attackRate >= 1.6f)
        {
            PlayerStats.attackRate = 1.6f;
        }

        walk.Play();
        walk.Pause();
        hit.Play();
        hit.Stop();
    }

    void Update()
    {
        #region Movement
        movement.x = Input.GetAxisRaw("Horizontal"); 
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;

        hf = movement.x > 0.01f ? movement.x : movement.x < -0.01f ? 1 : 0;
        vf = movement.y > 0.01f ? movement.y : movement.y < -0.01f ? 1 : 0;
        if (movement.x < -0.01f)
        {
            sr.flipX = false;
            GameManager.flipped = true;
            walk.UnPause();
        }
        else if (movement.x > 0.01f)
        {
            sr.flipX = true;
            GameManager.flipped = false;
            walk.UnPause();
        }
        
        if (movement.y != 0)
        {
            walk.UnPause();
        }

        if(movement.y == 0 && movement.x == 0)
        {
            walk.Pause();
        }
       

        anim.SetFloat("Horizontal", hf);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", vf);

        #endregion Movement
        //all basic movement animations
        
        #region Shooting
            if (Input.GetKey(KeyCode.DownArrow) && isStabbing == false)
            {
                anim.SetBool("swingDown", true);
            }
            else
            {
                anim.SetBool("swingDown", false);
            }

            if (Input.GetKey(KeyCode.RightArrow) && isStabbing == false)
            {
                anim.SetBool("swingSide", true);
                sr.flipX = true;
            }
            else if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false || isStabbing == true)
            {
                anim.SetBool("swingSide", false);
            }

            if (Input.GetKey(KeyCode.LeftArrow) && isStabbing == false)
            {
                anim.SetBool("swingSide", true);
                sr.flipX = false;
            }
            else if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false || isStabbing == true)
            {

                anim.SetBool("swingSide", false);
            }

            if (Input.GetKey(KeyCode.UpArrow) && isStabbing == false)
            {
                anim.SetBool("swingUp", true);
            }
            else
            {
                anim.SetBool("swingUp", false);
            }
            #endregion Shooting
        //all basic shooting animations

        #region Stabbing Sword

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    isStabbing = true;
                }
                else
                {
                    isStabbing = false;
                }

                if (Input.GetKey(KeyCode.UpArrow) && isStabbing == true)
                {
                    anim.SetBool("stabUp", true);
                }
                else
                {
                    anim.SetBool("stabUp", false);
                }

                if (Input.GetKey(KeyCode.DownArrow) && isStabbing == true)
                {
                    anim.SetBool("stabDown", true);
                }
                else
                {
                    anim.SetBool("stabDown", false);
                }

                if (Input.GetKey(KeyCode.RightArrow) && isStabbing == true)
                {
                    anim.SetBool("stabSide", true);
                    sr.flipX = true;
                }
                else if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false || isStabbing == false)
                {
                    anim.SetBool("stabSide", false);
                }

                if (Input.GetKey(KeyCode.LeftArrow) && isStabbing == true)
                {
                    anim.SetBool("stabSide", true);
                    sr.flipX = false;
                }
                else if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false || isStabbing == false)
                {

                    anim.SetBool("stabSide", false);
                }

        #endregion Stabbing Sword
        //all basic stabbing animations

        #region PlayerStatModifiers
        PlayerStats.speed = PlayerStats.speed + PlayerStats.speedModifier;
        PlayerStats.attackRate= PlayerStats.attackRate + PlayerStats.attackRateModifier;
        PlayerStats.strength = PlayerStats.strength + PlayerStats.strengthModifier;
        #endregion PlayerStatModifiers
        //all player stat modifications

    }

    void FixedUpdate()
    {
        rb2.velocity = new Vector2(movement.x * movementSpeed * Time.deltaTime * PlayerStats.speed, 
            movement.y * movementSpeed * Time.deltaTime * PlayerStats.speed);

       //Scene stuff
        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene("Level2");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("FloorClearScreen");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Spider") || collision.gameObject.CompareTag("Slime") || 
            collision.gameObject.CompareTag("Bat") || collision.gameObject.CompareTag("Bat1") || collision.gameObject.CompareTag("Slime1"))
        {
            if(EnemyStats.isHit == false)
            {
                hit.Play();

                sr.color = EnemyStats.damage;

                Invoke("DamageColorNormal", .2f);
            }
        }

        if(collision.gameObject.CompareTag("Enemy Bullet"))
        {
            hit.Play();

            sr.color = EnemyStats.damage;

            Invoke("DamageColorNormal", .2f);
        }
    }

    private void DamageColorNormal()
    {
        sr.color = new Color(1, 1, 1);
    }
}
