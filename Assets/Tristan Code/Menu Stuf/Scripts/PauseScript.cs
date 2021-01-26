using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    //Stuff that needs to be disabled >:)
    public GameObject Agnes;
    public GameObject Shooting;
    public GameObject Minimap;
    public GameObject Frame;
    public GameObject Inventory;
    public GameObject Stats;
    public GameObject System;
    public GameObject GrazeBox;

    public GameObject ConfidenceBG;
    public Image ConfidencePoint;

    private bool hasOpened;

    void Start()
    {
        Inventory.SetActive(false);
        Stats.SetActive(false);
        System.SetActive(false);
    }

    void Update()
    {
        //Opening and Closing
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!hasOpened) OpenMenu();
            else CloseMenu();
        }

        if(hasOpened == true)
        {
            Agnes.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

    } 
    public void CloseMenu()
    {
        //Turning minimap Back on
        GameObject InfoText = GameObject.FindWithTag("InfoText");
        Destroy(InfoText);
        GameObject StatText = GameObject.FindWithTag("StatText");
        Destroy(StatText);
        hasOpened = false;
        Inventory.SetActive(false);
        Stats.SetActive(false);
        System.SetActive(false);
        Frame.SetActive(true);
        if (Minimap != null)
        {
            Minimap.SetActive(true);
        }

        //Enabling Scripts
        Enemy.stop = false;
        if (SceneWatcher.sceneName != null)
        {
            if (SceneWatcher.sceneName.Equals("Level1"))
            {
                Shooting.GetComponent<ShootandStab>().enabled = true;
                Agnes.GetComponent<PlayerMovement>().enabled = true;
            }
            else
            {
                Shooting.GetComponent<ShootandStabLevel2>().enabled = true;
                Agnes.GetComponent<PlayerMovementLevel2>().enabled = true;
            }

        }

        Agnes.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        Agnes.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        Agnes.GetComponent<GrazeSystem>().enabled = true;
        ConfidenceBG.SetActive(true);
        ConfidencePoint.enabled = true;
    }

    public void OpenMenu()
    {
        //Disabling Scripts
        hasOpened = true;
        Inventory.SetActive(true);
        Frame.SetActive(false);
        if (Minimap != null)
        {
            Minimap.SetActive(false);
        }
        Agnes.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        Agnes.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        Agnes.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        Agnes.GetComponent<GrazeSystem>().enabled = false;
        Enemy.stop = true;
        if (SceneWatcher.sceneName != null)
        {
            if (SceneWatcher.sceneName.Equals("Level1"))
            {
                Shooting.GetComponent<ShootandStab>().enabled = false;
                Agnes.GetComponent<PlayerMovement>().enabled = false;
            }
            else
            {
                Shooting.GetComponent<ShootandStabLevel2>().enabled = false;
                Agnes.GetComponent<PlayerMovementLevel2>().enabled = false;
            }

        }
        ConfidenceBG.SetActive(false);
        ConfidencePoint.enabled = false;
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
