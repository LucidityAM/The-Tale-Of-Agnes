using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponinInventory : MonoBehaviour
{
    Image weapon;

    public void Awake()
    {
        weapon = gameObject.GetComponent<Image>();
    }
    public void Update()
    {
        if (gameObject.tag == ("Weapon" + WeaponStats.weaponNo))
        {
            weapon.enabled = true;
        }
        else
        {
            weapon.enabled = false;
        }
    }
}
