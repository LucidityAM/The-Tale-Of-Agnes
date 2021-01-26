using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowToggle : MonoBehaviour
{
    public GameObject Darkness;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Darkness.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Darkness.SetActive(false);
    }
}
