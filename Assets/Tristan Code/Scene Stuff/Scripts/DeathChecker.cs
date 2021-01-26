using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GiveUpCheck();    
    }

    public void GiveUpCheck()
    {
        if (GameManager.confidenceLevel <= -6)
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

            SceneManager.LoadScene("GameOver");
        }
    }

    
}
