using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalPause : MonoBehaviour
{
    //Inventory Prefabs 
    public GameObject Inventory;
    public GameObject Stats;
    public GameObject System;


    //Bool value
    private bool hasOpened;

    // Start is called before the first frame update
    void Start()
    {
        Inventory.SetActive(false);
        Stats.SetActive(false);
        System.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Opening and Closing
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!hasOpened) OpenMenu();
            else CloseMenu();
        }

    }

    public void CloseMenu()
    {
        GameObject InfoText = GameObject.FindWithTag("InfoText");
        Destroy(InfoText);

        hasOpened = false;
        Inventory.SetActive(false);
        Stats.SetActive(false);
        System.SetActive(false);
    }
    public void OpenMenu()
    {
        hasOpened = true;
        Inventory.SetActive(true);
    }

    public void OpenStats()
    {
        Inventory.SetActive(false);
        System.SetActive(false);
        Stats.SetActive(true);
    }

    public void OpenInventory()
    {
        Inventory.SetActive(true);
        System.SetActive(false);
        Stats.SetActive(false);
    }

    public void OpenSystem()
    {
        Inventory.SetActive(false);
        System.SetActive(true);
        Stats.SetActive(false);
    }
}
