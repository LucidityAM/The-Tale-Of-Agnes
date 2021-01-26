using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMove : MonoBehaviour
{
    public Transform agnes;

    void Update()
    {
        gameObject.transform.position = agnes.transform.position;
    }
}
