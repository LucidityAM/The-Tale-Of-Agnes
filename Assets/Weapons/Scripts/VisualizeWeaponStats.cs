using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizeWeaponStats : MonoBehaviour
{
    public RarityTracker rarityTracker;

    public GameObject InfoHover;

    public Transform spawnLocation;
    public GameObject inventoryUI;
    public bool instantiated;

    //public bool queriesHitTriggers = true;
    public void Awake()
    {
        inventoryUI = GameObject.FindWithTag("InventoryUI");
        if(spawnLocation == null)
        {
            spawnLocation = inventoryUI.transform;
        }
        
    }


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

    public void InstantiateInfo()
    {

        if (this.gameObject.CompareTag("Weapon1") && rarityTracker.rarity == 1)
        {
            StatString.weaponName = "Durandal";
            StatString.rarity = "Commoner";
            StatString.flavorText = "An indestructible sword, owned once by the head knight of Aeronia, lost forever once the knight died.";
            StatString.strength = weaponStats[0, 0];
            StatString.attackRate = weaponStats[0, 1];
            StatString.speed = weaponStats[0, 2];
            StatString.resolve = weaponStats[0, 3];
            StatString.range = weaponStats[0, 4];
        }
        else if (this.gameObject.CompareTag("Weapon1") && rarityTracker.rarity == 2)
        {
            StatString.weaponName = "Durandal";
            StatString.rarity = "Knight";
            StatString.flavorText = "An indestructible sword, owned once by the head knight of Aeronia, lost forever once the knight died.";
            StatString.strength = weaponStats[1, 0];
            StatString.attackRate = weaponStats[1, 1];
            StatString.speed = weaponStats[1, 2];
            StatString.resolve = weaponStats[1, 3];
            StatString.range = weaponStats[1, 4];
        }
        else if (this.gameObject.CompareTag("Weapon1") && rarityTracker.rarity == 3)
        {
            StatString.weaponName = "Durandal";
            StatString.rarity = "King";
            StatString.flavorText = "An indestructible sword, owned once by the head knight of Aeronia, lost forever once the knight died.";
            StatString.strength = weaponStats[2, 0];
            StatString.attackRate = weaponStats[2, 1];
            StatString.speed = weaponStats[2, 2];
            StatString.resolve = weaponStats[2, 3];
            StatString.range = weaponStats[2, 4];
        }
        else if (this.gameObject.CompareTag("Weapon2") && rarityTracker.rarity == 1)
        {
            StatString.weaponName = "Laevateinn";
            StatString.rarity = "Commoner";
            StatString.flavorText = "A sword lost to time; this mystical weapon is said to be able to kill with such ferocity that full cities fall beneath its blade.";
            StatString.strength = weaponStats[3, 0];
            StatString.attackRate = weaponStats[3, 1];
            StatString.speed = weaponStats[3, 2];
            StatString.resolve = weaponStats[3, 3];
            StatString.range = weaponStats[3, 4];
        }
        else if (this.gameObject.CompareTag("Weapon2") && rarityTracker.rarity == 2)
        {
            StatString.weaponName = "Laevateinn";
            StatString.rarity = "Knight";
            StatString.flavorText = "A sword lost to time; this mystical weapon is said to be able to kill with such ferocity that full cities fall beneath its blade.";
            StatString.strength = weaponStats[4, 0];
            StatString.attackRate = weaponStats[4, 1];
            StatString.speed = weaponStats[4, 2];
            StatString.resolve = weaponStats[4, 3];
            StatString.range = weaponStats[4, 4];
        }
        else if (this.gameObject.CompareTag("Weapon2") && rarityTracker.rarity == 3)
        {
            StatString.weaponName = "Laevateinn";
            StatString.rarity = "King";
            StatString.flavorText = "A sword lost to time; this mystical weapon is said to be able to kill with such ferocity that full cities fall beneath its blade.";
            StatString.strength = weaponStats[5, 0];
            StatString.attackRate = weaponStats[5, 1];
            StatString.speed = weaponStats[5, 2];
            StatString.resolve = weaponStats[5, 3];
            StatString.range = weaponStats[5, 4];
        }
        else if (this.gameObject.CompareTag("Weapon3") && rarityTracker.rarity == 1)
        {
            StatString.weaponName = "Balance Blade";
            StatString.rarity = "Commoner";
            StatString.flavorText = "A perfectly respectable and balanced sword. Perhaps owned once by a powerful knight, it is now weathered with age.";
            StatString.strength = weaponStats[6, 0];
            StatString.attackRate = weaponStats[6, 1];
            StatString.speed = weaponStats[6, 2];
            StatString.resolve = weaponStats[6, 3];
            StatString.range = weaponStats[6, 4];
        }
        else if (this.gameObject.CompareTag("Weapon3") && rarityTracker.rarity == 2)
        {
            StatString.weaponName = "Balance Blade";
            StatString.rarity = "Knight";
            StatString.flavorText = "A perfectly respectable and balanced sword. Perhaps owned once by a powerful knight, it is now weathered with age.";
            StatString.strength = weaponStats[7, 0];
            StatString.attackRate = weaponStats[7, 1];
            StatString.speed = weaponStats[7, 2];
            StatString.resolve = weaponStats[7, 3];
            StatString.range = weaponStats[7, 4];
        }
        else if (this.gameObject.CompareTag("Weapon3") && rarityTracker.rarity == 3)
        {
            StatString.weaponName = "Balance Blade";
            StatString.rarity = "King";
            StatString.flavorText = "A perfectly respectable and balanced sword. Perhaps owned once by a powerful knight, it is now weathered with age.";
            StatString.strength = weaponStats[8, 0];
            StatString.attackRate = weaponStats[8, 1];
            StatString.speed = weaponStats[8, 2];
            StatString.resolve = weaponStats[8, 3];
            StatString.range = weaponStats[8, 4];
        }
        else if (this.gameObject.CompareTag("Weapon4"))
        {
            StatString.weaponName = "Stick";
            StatString.rarity = "Trash";
            StatString.flavorText = "A random stick picked up off the floor, it’s not much, but it works for now.";
            StatString.strength = weaponStats[9, 0];
            StatString.attackRate = weaponStats[9, 1];
            StatString.speed = weaponStats[9, 2];
            StatString.resolve = weaponStats[9, 3];
            StatString.range = weaponStats[9, 4];
        }
        else if (this.gameObject.CompareTag("Weapon5") && rarityTracker.rarity == 1)
        {
            StatString.weaponName = "Lightbane";
            StatString.rarity = "Commoner";
            StatString.flavorText = "A fast rapier, rumored to have the ability to cut through material at the speed of light.";
            StatString.strength = weaponStats[10, 0];
            StatString.attackRate = weaponStats[10, 1];
            StatString.speed = weaponStats[10, 2];
            StatString.resolve = weaponStats[10, 3];
            StatString.range = weaponStats[10, 4];
        }
        else if (this.gameObject.CompareTag("Weapon5") && rarityTracker.rarity == 2)
        {
            StatString.weaponName = "Lightbane";
            StatString.rarity = "Knight";
            StatString.flavorText = "A fast rapier, rumored to have the ability to cut through material at the speed of light.";
            StatString.strength = weaponStats[11, 0];
            StatString.attackRate = weaponStats[11, 1];
            StatString.speed = weaponStats[11, 2];
            StatString.resolve = weaponStats[11, 3];
            StatString.range = weaponStats[11, 4];
        }
        else if (this.gameObject.CompareTag("Weapon5") && rarityTracker.rarity == 3)
        {
            StatString.weaponName = "Lightbane";
            StatString.rarity = "King";
            StatString.flavorText = "A fast rapier, rumored to have the ability to cut through material at the speed of light.";
            StatString.strength = weaponStats[12, 0];
            StatString.attackRate = weaponStats[12, 1];
            StatString.speed = weaponStats[12, 2];
            StatString.resolve = weaponStats[12, 3];
            StatString.range = weaponStats[12, 4];
        }
        else if (this.gameObject.CompareTag("Weapon6") && rarityTracker.rarity == 1)
        {
            StatString.weaponName = "Steel Sword";
            StatString.rarity = "Commoner";
            StatString.flavorText = "A basic steel sword, sold in many stores around the land.";
            StatString.strength = weaponStats[13, 0];
            StatString.attackRate = weaponStats[13, 1];
            StatString.speed = weaponStats[13, 2];
            StatString.resolve = weaponStats[13, 3];
            StatString.range = weaponStats[13, 4];
        }
        else if (this.gameObject.CompareTag("Weapon6") && rarityTracker.rarity == 2)
        {
            StatString.weaponName = "Steel Sword";
            StatString.rarity = "Knight";
            StatString.flavorText = "A basic steel sword, sold in many stores around the land.";
            StatString.strength = weaponStats[14, 0];
            StatString.attackRate = weaponStats[14, 1];
            StatString.speed = weaponStats[14, 2];
            StatString.resolve = weaponStats[14, 3];
            StatString.range = weaponStats[14, 4];
        }
        else if (this.gameObject.CompareTag("Weapon6") && rarityTracker.rarity == 3)
        {
            StatString.weaponName = "Steel Sword";
            StatString.rarity = "King";
            StatString.flavorText = "A basic steel sword, sold in many stores around the land.";
            StatString.strength = weaponStats[15, 0];
            StatString.attackRate = weaponStats[15, 1];
            StatString.speed = weaponStats[15, 2];
            StatString.resolve = weaponStats[15, 3];
            StatString.range = weaponStats[15, 4];
        }
        else if (this.gameObject.CompareTag("Weapon7") && rarityTracker.rarity == 1)
        {
            StatString.weaponName = "Joyeuse";
            StatString.rarity = "Commoner";
            StatString.flavorText = " A legendary sword, once owned by King Charlemagne, it was thought to have been stolen, however, it has now fallen into your hands.";
            StatString.strength = weaponStats[16, 0];
            StatString.attackRate = weaponStats[16, 1];
            StatString.speed = weaponStats[16, 2];
            StatString.resolve = weaponStats[16, 3];
            StatString.range = weaponStats[16, 4];
        }
        else if (this.gameObject.CompareTag("Weapon7") && rarityTracker.rarity == 2)
        {
            StatString.weaponName = "Joyeuse";
            StatString.rarity = "Knight";
            StatString.flavorText = " A legendary sword, once owned by King Charlemagne, it was thought to have been stolen, however, it has now fallen into your hands.";
            StatString.strength = weaponStats[17, 0];
            StatString.attackRate = weaponStats[17, 1];
            StatString.speed = weaponStats[17, 2];
            StatString.resolve = weaponStats[17, 3];
            StatString.range = weaponStats[17, 4];
        }
        else if (this.gameObject.CompareTag("Weapon7") && rarityTracker.rarity == 3)
        {
            StatString.weaponName = "Joyeuse";
            StatString.rarity = "King";
            StatString.flavorText = " A legendary sword, once owned by King Charlemagne, it was thought to have been stolen, however, it has now fallen into your hands.";
            StatString.strength = weaponStats[18, 0];
            StatString.attackRate = weaponStats[18, 1];
            StatString.speed = weaponStats[18, 2];
            StatString.resolve = weaponStats[18, 3];
            StatString.range = weaponStats[18, 4];
        }
        else if (this.gameObject.CompareTag("Weapon8") && rarityTracker.rarity == 1)
        {
            StatString.weaponName = "Kinkiller";
            StatString.rarity = "Commoner";
            StatString.flavorText = "Used to slaughter thousands, this sword has developed a mind of its own. It is extremely unwieldy, despite its power to level mountains.";
            StatString.strength = weaponStats[19, 0];
            StatString.attackRate = weaponStats[19, 1];
            StatString.speed = weaponStats[19, 2];
            StatString.resolve = weaponStats[19, 3];
            StatString.range = weaponStats[19, 4];
        }
        else if (this.gameObject.CompareTag("Weapon8") && rarityTracker.rarity == 2)
        {
            StatString.weaponName = "Kinkiller";
            StatString.rarity = "Knight";
            StatString.flavorText = "Used to slaughter thousands, this sword has developed a mind of its own. It is extremely unwieldy, despite its power to level mountains.";
            StatString.strength = weaponStats[20, 0];
            StatString.attackRate = weaponStats[20, 1];
            StatString.speed = weaponStats[20, 2];
            StatString.resolve = weaponStats[20, 3];
            StatString.range = weaponStats[20, 4];
        }
        else if (this.gameObject.CompareTag("Weapon8") && rarityTracker.rarity == 3)
        {
            StatString.weaponName = "Kinkiller";
            StatString.rarity = "King";
            StatString.flavorText = "Used to slaughter thousands, this sword has developed a mind of its own. It is extremely unwieldy, despite its power to level mountains.";
            StatString.strength = weaponStats[21, 0];
            StatString.attackRate = weaponStats[21, 1];
            StatString.speed = weaponStats[21, 2];
            StatString.resolve = weaponStats[21, 3];
            StatString.range = weaponStats[21, 4];
        }
        else if (this.gameObject.CompareTag("Weapon9") && rarityTracker.rarity == 1)
        {
            StatString.weaponName = "Sac Sword";
            StatString.rarity = "Commoner";
            StatString.flavorText = "A sacred sword with a small tag of paper. The tag appears to have once been a name, however, it now only reads “sac”";
            StatString.strength = weaponStats[22, 0];
            StatString.attackRate = weaponStats[22, 1];
            StatString.speed = weaponStats[22, 2];
            StatString.resolve = weaponStats[22, 3];
            StatString.range = weaponStats[22, 4];
        }
        else if (this.gameObject.CompareTag("Weapon9") && rarityTracker.rarity == 2)
        {
            StatString.weaponName = "Sac Sword";
            StatString.rarity = "Knight";
            StatString.flavorText = "A sacred sword with a small tag of paper. The tag appears to have once been a name, however, it now only reads “sac”";
            StatString.strength = weaponStats[23, 0];
            StatString.attackRate = weaponStats[23, 1];
            StatString.speed = weaponStats[23, 2];
            StatString.resolve = weaponStats[23, 3];
            StatString.range = weaponStats[23, 4];
        }
        else if (this.gameObject.CompareTag("Weapon9") && rarityTracker.rarity == 3)
        {
            StatString.weaponName = "Sac Sword";
            StatString.rarity = "King";
            StatString.flavorText = "A sacred sword with a small tag of paper. The tag appears to have once been a name, however, it now only reads “sac”";
            StatString.strength = weaponStats[24, 0];
            StatString.attackRate = weaponStats[24, 1];
            StatString.speed = weaponStats[24, 2];
            StatString.resolve = weaponStats[24, 3];
            StatString.range = weaponStats[24, 4];
        }
        else if (this.gameObject.CompareTag("Weapon10") && rarityTracker.rarity == 1)
        {
            StatString.weaponName = "Requiem";
            StatString.rarity = "Commoner";
            StatString.flavorText = "Each of Requiem's owners have now met an unfortunate end. Over decades, the sword has developed a will to stop the deaths of its owners.";
            StatString.strength = weaponStats[25, 0];
            StatString.attackRate = weaponStats[25, 1];
            StatString.speed = weaponStats[25, 2];
            StatString.resolve = weaponStats[25, 3];
            StatString.range = weaponStats[25, 4];
        }
        else if (this.gameObject.CompareTag("Weapon10") && rarityTracker.rarity == 2)
        {
            StatString.weaponName = "Requiem";
            StatString.rarity = "Knight";
            StatString.flavorText = "Each of Requiem's owners have now met an unfortunate end. Over decades, the sword has developed a will to stop the deaths of its owners.";
            StatString.strength = weaponStats[26, 0];
            StatString.attackRate = weaponStats[26, 1];
            StatString.speed = weaponStats[26, 2];
            StatString.resolve = weaponStats[26, 3];
            StatString.range = weaponStats[26, 4];
        }
        else if (this.gameObject.CompareTag("Weapon10") && rarityTracker.rarity == 3)
        {
            StatString.weaponName = "Requiem";
            StatString.rarity = "King";
            StatString.flavorText = "Each of Requiem's owners have now met an unfortunate end. Over decades, the sword has developed a will to stop the deaths of its owners.";
            StatString.strength = weaponStats[27, 0];
            StatString.attackRate = weaponStats[27, 1];
            StatString.speed = weaponStats[27, 2];
            StatString.resolve = weaponStats[27, 3];
            StatString.range = weaponStats[27, 4];
        }
        else if (this.gameObject.CompareTag("Weapon11"))
        {
            StatString.weaponName = "Stripes' Cutlass";
            StatString.rarity = "Boss";
            StatString.flavorText = "A cutlass stolen from the skeleton living in The Dragon's dungeon";
            StatString.strength = weaponStats[28, 0];
            StatString.attackRate = weaponStats[28, 1];
            StatString.speed = weaponStats[28, 2];
            StatString.resolve = weaponStats[28, 3];
            StatString.range = weaponStats[28, 4];
        }

        if (instantiated == false)
        {
            Vector3 position = new Vector3(gameObject.transform.position.x + 400, gameObject.transform.position.y * 1.15f);
            Instantiate(InfoHover, position, Quaternion.identity, spawnLocation);
            instantiated = true;
        }
    }

    public void DestroyInfo()
    {
        GameObject InfoText = GameObject.FindWithTag("InfoText");
        Destroy(InfoText);

        instantiated = false;
    }
}
