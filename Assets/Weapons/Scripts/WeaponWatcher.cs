using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponWatcher : MonoBehaviour
{
    public bool[] isFilled = new bool[20];

    public InventoryWeapons inventoryWeapons;

    public GameObject[] Weapons = new GameObject[11];

    public int rarityChance;
    private static readonly Random getrandom = new Random();

    public AudioSource pickup;

    private void Random()
    {
        System.Random rnd = new System.Random();

        for (int j = 0; j < isFilled.Length; j++)
        {
            isFilled[j] = false;
        }

        if(WeaponStats.raritiesAssigned == false)
        {
            for (int k = 0; k < WeaponStats.rarities.Length; k++)
            {
                rarityChance = rnd.Next(1, 100);

                if (rarityChance <= 50)
                {
                    WeaponStats.rarity = 1;
                }
                else if (rarityChance <= 85 && rarityChance > 50)
                {
                    WeaponStats.rarity = 2;
                }
                else if (rarityChance > 85)
                {
                    WeaponStats.rarity = 3;
                }

                WeaponStats.rarities[k] = WeaponStats.rarity;
                inventoryWeapons.rarities[k] = WeaponStats.rarity;
                if (k == WeaponStats.rarities.Length - 1)
                {
                    WeaponStats.raritiesAssigned = true;
                }
            }
        }
    }

    private void Start()
    {
        Random();

        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "Level2" || scene.name == "Level3" || scene.name == "FloorClearScreen")
        {
            for(int i = 0; i < 11; i++)
            {
                if (WeaponStats.objectsInSpaces[i] != null)
                {
                    if (WeaponStats.objectsInSpaces[i].tag == "Weapon1")
                    {
                        Instantiate(Weapons[0], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon2")
                    {
                        Instantiate(Weapons[1], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon3")
                    {
                        Instantiate(Weapons[2], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon4")
                    {
                        Instantiate(Weapons[3], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon5")
                    {
                        Instantiate(Weapons[4], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon6")
                    {
                        Instantiate(Weapons[5], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon7")
                    {
                        Instantiate(Weapons[6], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon8")
                    {
                        Instantiate(Weapons[7], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon9")
                    {
                        Instantiate(Weapons[8], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon10")
                    {
                        Instantiate(Weapons[9], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.objectsInSpaces[i].tag == "Weapon11")
                    {
                        Instantiate(Weapons[10], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                        isFilled[i] = true;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Weapon1")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[0], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 0;
                    WeaponStats.objectsInSpaces[i] = Weapons[0];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon2")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[1], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 1;
                    WeaponStats.objectsInSpaces[i] = Weapons[1];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon3")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[2], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 2;
                    WeaponStats.objectsInSpaces[i] = Weapons[2];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon4")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[3], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 3;
                    WeaponStats.objectsInSpaces[i] = Weapons[3];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon5")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[4], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 4;
                    WeaponStats.objectsInSpaces[i] = Weapons[4];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon6")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[5], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 5;
                    WeaponStats.objectsInSpaces[i] = Weapons[5];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon7")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[6], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 6;
                    WeaponStats.objectsInSpaces[i] = Weapons[6];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon8")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[7], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 7;
                    WeaponStats.objectsInSpaces[i] = Weapons[7];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon9")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[8], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 8;
                    WeaponStats.objectsInSpaces[i] = Weapons[8];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon10")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[9], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 9;
                    WeaponStats.objectsInSpaces[i] = Weapons[9];
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "Weapon11")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    pickup.Play();
                    Instantiate(Weapons[10], inventoryWeapons.inventorySpace[i], instantiateInWorldSpace: false);
                    WeaponStats.weaponsInSpaces[i] = 10;
                    WeaponStats.objectsInSpaces[i] = Weapons[10];
                    isFilled[i] = true;
                    break;
                }
            }
        }
    }

}
