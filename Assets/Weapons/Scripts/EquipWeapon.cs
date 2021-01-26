using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EquipWeapon : MonoBehaviour
{
    public GameObject[] Weapon = new GameObject[1];

    public void Equip()
    {
        for (int i = 0; i < 11; i++)
        {
            if (gameObject.tag == "Weapon" + (i + 1))
            {
                WeaponStats.weaponNo = i + 1;
            }
        }
    }
}
