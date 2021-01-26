using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RarityTracker : MonoBehaviour
{
    public int rarity;
    void Awake()
    {
        Invoke("Rarity", 0f);
    }

    public void Rarity()
    {
        for (int i = 0; i < 10; i++)
        {
            if (gameObject.tag == "Weapon" + (i + 1))
            {
                rarity = WeaponStats.rarities[i + 1];
            }
        }
    }
}
