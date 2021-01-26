using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("isSwingingDown", true);
        }
        else
        {
            anim.SetBool("isSwingingDown", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isSwingingRight", true);
        }
        else
        {
            anim.SetBool("isSwingingRight", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isSwingingLeft", true);
        }
        else
        {
            anim.SetBool("isSwingingLeft", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("isSwingingUp", true);
        }
        else
        {
            anim.SetBool("isSwingingUp", false);
        }
    }
}