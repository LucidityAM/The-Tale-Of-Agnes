using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < WeaponStats.rarities.Length; i++)
        {
            WeaponStats.rarities[i] = 0;
        }
        for (int j = 0; j < WeaponStats.weaponsInSpaces.Length; j++)
        {
            WeaponStats.weaponsInSpaces[j] = 0;
        }
        for (int k = 0; k < WeaponStats.objectsInSpaces.Length; k++)
        {
            WeaponStats.objectsInSpaces[k] = null;
        }

        WeaponStats.weaponNo = 0;
        WeaponStats.rarity = 0;
        WeaponStats.raritiesAssigned = false;

        SceneLoading.Level1 = false;

        WeaponStats.weaponNo = 0;
        WeaponStats.rarity = 0;

        PlayerStats.currentLevel = 0;

        PlayerStats.attackRateModifier = 0;
        PlayerStats.strengthModifier = 0;
        PlayerStats.speedModifier = 0;

    }
}
