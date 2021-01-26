using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipedWeapon : MonoBehaviour
{
    public float[,] weaponStats = new float[29, 5]
   {
        //weapon 1, high attack, slow
        {10f, .5f, .9f, 1f, 500f}, //Commoner rarity
        {11f, .6f, 1f, 2f, 550f}, //Knight rarity
        {12f, .65f, 1.2f, 3f, 600f}, //King rarity

        //weapon 2, fast attack rate, fast speed, low attack
        {4f, 1.3f, 1.3f, 1f, 1000f}, //Commoner rarity
        {6f, 1.3f, 1.35f, 2f, 1000f}, //Knight rarity
        {8f, 1.3f, 1.4f, 3f, 1000f}, //King rarity

        //weapon 3, balanced
        {5f, 1.1f, 1f, 1f, 700f}, //Commoner rarity
        {7f, 1.15f, 1.1f, 2f, 750f}, //Knight rarity
        {9f, 1.2f, 1.13f, 3f, 800f}, //King rarity

        //weapon 4, stick, basic, bad
        {4f, 1f, 1f, 1f, 1000f},

        //weapon 5, fast, extremely low damage and low range
        {3.5f, 1.3f, 1.45f, 1f, 600f}, //Commoner rarity
        {5f, 1.3f, 1.45f, 2f, 650f}, //Knight rarity
        {5.5f, 1.4f, 1.45f, 3f, 700f}, //King rarity

         //weapon 6, completely average, neither good, nor bad
        {5f, 1f, 1f, 1f, 700f}, //Commoner rarity
        {7f, 1.3f, 1.1f, 2f, 750f}, //Knight rarity
        {9f, 1.5f, 1.13f, 3f, 800f}, //King rarity

         //weapon 7, decent attack speed, high damage, high speed
        {8f, .65f, 1.2f, 1f, 500f}, //Commoner rarity
        {10f, .7f, 1.3f, 2f, 550f}, //Knight rarity
        {12f, .75f, 1.4f, 3f, 600f}, //King rarity

         //weapon 8, extreme damage, slow, low range
        {30f, .1f, .2f, 1f, 150f}, //Commoner rarity
        {35f, .1f, .25f, 2f, 200f}, //Knight rarity
        {42f, .1f, .3f, 3f, 250f}, //King rarity

         //Insane speed and attack rate, horrid damage
        {1f, 1.5f, 1.5f, 2f, 1000f}, //Commoner rarity
        {2f, 1.5f, 1.5f, 2f, 1000f}, //Knight rarity
        {3f, 1.5f, 1.5f, 3f, 1000f}, //King rarity

         //weapon 10, Requiem
        {1f, 1f, 1f, 10f, 500f}, //Commoner rarity
        {2f, 1.2f, 1.1f, 10f, 500f}, //Knight rarity
        {3f, 1.4f, 1.13f, 10f, 500f}, //King rarity

        {11f, .75f, 1.3f, 3f, 1000f}, //Boss Weapon
   };

    public void Update()
    {
        if (WeaponStats.weaponNo == 1 && WeaponStats.rarities[1] == 1)
        {
            PlayerStats.strength = weaponStats[0, 0];
            PlayerStats.attackRate = weaponStats[0, 1];
            PlayerStats.speed = weaponStats[0, 2];
            PlayerStats.resolve = weaponStats[0, 3];
            PlayerStats.range = weaponStats[0, 4];
        }
        else if (WeaponStats.weaponNo == 1 && WeaponStats.rarities[1] == 2)
        {
            PlayerStats.strength = weaponStats[1, 0];
            PlayerStats.attackRate = weaponStats[1, 1];
            PlayerStats.speed = weaponStats[1, 2];
            PlayerStats.resolve = weaponStats[1, 3];
            PlayerStats.range = weaponStats[1, 4];
        }
        else if (WeaponStats.weaponNo == 1 && WeaponStats.rarities[1] == 3)
        {
            PlayerStats.strength = weaponStats[2, 0];
            PlayerStats.attackRate = weaponStats[2, 1];
            PlayerStats.speed = weaponStats[2, 2];
            PlayerStats.resolve = weaponStats[2, 3];
            PlayerStats.range = weaponStats[2, 4];
        }
        if (WeaponStats.weaponNo == 2 && WeaponStats.rarities[2] == 1)
        {
            PlayerStats.strength = weaponStats[3, 0];
            PlayerStats.attackRate = weaponStats[3, 1];
            PlayerStats.speed = weaponStats[3, 2];
            PlayerStats.resolve = weaponStats[3, 3];
            PlayerStats.range = weaponStats[3, 4];
        }
        else if (WeaponStats.weaponNo == 2 && WeaponStats.rarities[2] == 2)
        {
            PlayerStats.strength = weaponStats[4, 0];
            PlayerStats.attackRate = weaponStats[4, 1];
            PlayerStats.speed = weaponStats[4, 2];
            PlayerStats.resolve = weaponStats[4, 3];
            PlayerStats.range = weaponStats[4, 4];
        }
        else if (WeaponStats.weaponNo == 2 && WeaponStats.rarities[2] == 3)
        {
            PlayerStats.strength = weaponStats[5, 0];
            PlayerStats.attackRate = weaponStats[5, 1];
            PlayerStats.speed = weaponStats[5, 2];
            PlayerStats.resolve = weaponStats[5, 3];
            PlayerStats.range = weaponStats[5, 4];
        }
        if (WeaponStats.weaponNo == 3 && WeaponStats.rarities[3] == 1)
        {
            PlayerStats.strength = weaponStats[6, 0];
            PlayerStats.attackRate = weaponStats[6, 1];
            PlayerStats.speed = weaponStats[6, 2];
            PlayerStats.resolve = weaponStats[6, 3];
            PlayerStats.range = weaponStats[6, 4];
        }
        else if (WeaponStats.weaponNo == 3 && WeaponStats.rarities[3] == 2)
        {
            PlayerStats.strength = weaponStats[7, 0];
            PlayerStats.attackRate = weaponStats[7, 1];
            PlayerStats.speed = weaponStats[7, 2];
            PlayerStats.resolve = weaponStats[7, 3];
            PlayerStats.range = weaponStats[7, 4];
        }
        else if (WeaponStats.weaponNo == 3 && WeaponStats.rarities[3] == 3)
        {
            PlayerStats.strength = weaponStats[8, 0];
            PlayerStats.attackRate = weaponStats[8, 1];
            PlayerStats.speed = weaponStats[8, 2];
            PlayerStats.resolve = weaponStats[8, 3];
            PlayerStats.range = weaponStats[8, 4];
        }
        if (WeaponStats.weaponNo == 4)
        {
            PlayerStats.strength = weaponStats[9, 0];
            PlayerStats.attackRate = weaponStats[9, 1];
            PlayerStats.speed = weaponStats[9, 2];
            PlayerStats.resolve = weaponStats[9, 3];
            PlayerStats.range = weaponStats[9, 4];
        }
        if (WeaponStats.weaponNo == 5 && WeaponStats.rarities[5] == 1)
        {
            PlayerStats.strength = weaponStats[10, 0];
            PlayerStats.attackRate = weaponStats[10, 1];
            PlayerStats.speed = weaponStats[10, 2];
            PlayerStats.resolve = weaponStats[10, 3];
            PlayerStats.range = weaponStats[10, 4];
        }
        else if (WeaponStats.weaponNo == 5 && WeaponStats.rarities[5] == 2)
        {
            PlayerStats.strength = weaponStats[11, 0];
            PlayerStats.attackRate = weaponStats[11, 1];
            PlayerStats.speed = weaponStats[11, 2];
            PlayerStats.resolve = weaponStats[11, 3];
            PlayerStats.range = weaponStats[11, 4];
        }
        else if (WeaponStats.weaponNo == 5  && WeaponStats.rarities[5] == 3)
        {
            PlayerStats.strength = weaponStats[12, 0];
            PlayerStats.attackRate = weaponStats[12, 1];
            PlayerStats.speed = weaponStats[12, 2];
            PlayerStats.resolve = weaponStats[12, 3];
            PlayerStats.range = weaponStats[12, 4];
        }
        if (WeaponStats.weaponNo == 6 && WeaponStats.rarities[6] == 1)
        {
            PlayerStats.strength = weaponStats[13, 0];
            PlayerStats.attackRate = weaponStats[13, 1];
            PlayerStats.speed = weaponStats[13, 2];
            PlayerStats.resolve = weaponStats[13, 3];
            PlayerStats.range = weaponStats[13, 4];
        }
        else if (WeaponStats.weaponNo == 6 && WeaponStats.rarities[6] == 2)
        {
            PlayerStats.strength = weaponStats[14, 0];
            PlayerStats.attackRate = weaponStats[14, 1];
            PlayerStats.speed = weaponStats[14, 2];
            PlayerStats.resolve = weaponStats[14, 3];
            PlayerStats.range = weaponStats[14, 4];
        }
        else if (WeaponStats.weaponNo == 6 && WeaponStats.rarities[6] == 3)
        {
            PlayerStats.strength = weaponStats[15, 0];
            PlayerStats.attackRate = weaponStats[15, 1];
            PlayerStats.speed = weaponStats[15, 2];
            PlayerStats.resolve = weaponStats[15, 3];
            PlayerStats.range = weaponStats[15, 4];
        }
        if (WeaponStats.weaponNo == 7 && WeaponStats.rarities[7] == 1)
        {
            PlayerStats.strength = weaponStats[16, 0];
            PlayerStats.attackRate = weaponStats[16, 1];
            PlayerStats.speed = weaponStats[16, 2];
            PlayerStats.resolve = weaponStats[16, 3];
            PlayerStats.range = weaponStats[16, 4];
        }
        else if (WeaponStats.weaponNo == 7 && WeaponStats.rarities[7] == 2)
        {
            PlayerStats.strength = weaponStats[17, 0];
            PlayerStats.attackRate = weaponStats[17, 1];
            PlayerStats.speed = weaponStats[17, 2];
            PlayerStats.resolve = weaponStats[17, 3];
            PlayerStats.range = weaponStats[17, 4];
        }
        else if (WeaponStats.weaponNo == 7 && WeaponStats.rarities[7] == 3)
        {
            PlayerStats.strength = weaponStats[18, 0];
            PlayerStats.attackRate = weaponStats[18, 1];
            PlayerStats.speed = weaponStats[18, 2];
            PlayerStats.resolve = weaponStats[18, 3];
            PlayerStats.range = weaponStats[18, 4];
        }
        if (WeaponStats.weaponNo == 8 && WeaponStats.rarities[8] == 1)
        {
            PlayerStats.strength = weaponStats[19, 0];
            PlayerStats.attackRate = weaponStats[19, 1];
            PlayerStats.speed = weaponStats[19, 2];
            PlayerStats.resolve = weaponStats[19, 3];
            PlayerStats.range = weaponStats[19, 4];
        }
        else if (WeaponStats.weaponNo == 8 && WeaponStats.rarities[8] == 2)
        {
            PlayerStats.strength = weaponStats[20, 0];
            PlayerStats.attackRate = weaponStats[20, 1];
            PlayerStats.speed = weaponStats[20, 2];
            PlayerStats.resolve = weaponStats[20, 3];
            PlayerStats.range = weaponStats[20, 4];
        }
        else if (WeaponStats.weaponNo == 8 && WeaponStats.rarities[8] == 3)
        {
            PlayerStats.strength = weaponStats[21, 0];
            PlayerStats.attackRate = weaponStats[21, 1];
            PlayerStats.speed = weaponStats[21, 2];
            PlayerStats.resolve = weaponStats[21, 3];
            PlayerStats.range = weaponStats[21, 4];
        }
        if (WeaponStats.weaponNo == 9 && WeaponStats.rarities[9] == 1)
        {
            PlayerStats.strength = weaponStats[22, 0];
            PlayerStats.attackRate = weaponStats[22, 1];
            PlayerStats.speed = weaponStats[22, 2];
            PlayerStats.resolve = weaponStats[22, 3];
            PlayerStats.range = weaponStats[22, 4];
        }
        else if (WeaponStats.weaponNo == 9 && WeaponStats.rarities[9] == 2)
        {
            PlayerStats.strength = weaponStats[23, 0];
            PlayerStats.attackRate = weaponStats[23, 1];
            PlayerStats.speed = weaponStats[23, 2];
            PlayerStats.resolve = weaponStats[23, 3];
            PlayerStats.range = weaponStats[23, 4];
        }
        else if (WeaponStats.weaponNo == 9 && WeaponStats.rarities[9] == 3)
        {
            PlayerStats.strength = weaponStats[24, 0];
            PlayerStats.attackRate = weaponStats[24, 1];
            PlayerStats.speed = weaponStats[24, 2];
            PlayerStats.resolve = weaponStats[24, 3];
            PlayerStats.range = weaponStats[24, 4];
        }
        if (WeaponStats.weaponNo == 10 && WeaponStats.rarities[10] == 1)
        {
            PlayerStats.strength = weaponStats[25, 0];
            PlayerStats.attackRate = weaponStats[25, 1];
            PlayerStats.speed = weaponStats[25, 2];
            PlayerStats.resolve = weaponStats[25, 3];
            PlayerStats.range = weaponStats[25, 4];
        }
        else if (WeaponStats.weaponNo == 10 && WeaponStats.rarities[10] == 2)
        {
            PlayerStats.strength = weaponStats[26, 0];
            PlayerStats.attackRate = weaponStats[26, 1];
            PlayerStats.speed = weaponStats[26, 2];
            PlayerStats.resolve = weaponStats[26, 3];
            PlayerStats.range = weaponStats[26, 4];
        }
        else if (WeaponStats.weaponNo == 10 && WeaponStats.rarities[10] == 3)
        {
            PlayerStats.strength = weaponStats[27, 0];
            PlayerStats.attackRate = weaponStats[27, 1];
            PlayerStats.speed = weaponStats[27, 2];
            PlayerStats.resolve = weaponStats[27, 3];
            PlayerStats.range = weaponStats[27, 4];
        }
        else if (WeaponStats.weaponNo == 11)
        {
            PlayerStats.strength = weaponStats[28, 0];
            PlayerStats.attackRate = weaponStats[28, 1];
            PlayerStats.speed = weaponStats[28, 2];
            PlayerStats.resolve = weaponStats[28, 3];
            PlayerStats.range = weaponStats[28, 4];
        }
    }
        
}
