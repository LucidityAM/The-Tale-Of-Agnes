using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTextStats : MonoBehaviour
{
    public Text weaponName;
    public Text rarity;
    public Text flavorText;
    public Text attackRate;
    public Text strength;
    public Text speed;
    public Text resolve;
    public Text range;

    public Color32 positive = new Color32(67, 181, 129,255);
    public Color32 negative = new Color32(240, 71, 71,255);
    public Color32 neutral = new Color32(0,0,0,255);
    public Color32 commoner = new Color32(135,44,0,255);
    public Color32 knight = new Color32(52, 0, 168, 255);
    public Color32 king = new Color32(245, 177, 0, 255);

    public void Update()
    {
        weaponName.text = StatString.weaponName;
        rarity.text = StatString.rarity;
        flavorText.text = StatString.flavorText;

        if (StatString.rarity.Equals("Commoner") == true)
        {  
            rarity.color = commoner;
        }
        else if (StatString.rarity.Equals("Knight") == true)
        {
            rarity.color = knight;
        }
        else if (StatString.rarity.Equals("King") == true)
        {
            rarity.color = king;
        }


        if (StatString.strength > PlayerStats.strength)
        {
            strength.text = "Strength+";
            strength.color = positive;
        }
        else if(StatString.strength < PlayerStats.strength)
        {
            strength.text = "Strength-";
            strength.color = negative;
        }
        else
        {
            strength.text = "Strength";
            strength.color = neutral;
        }

        if (StatString.attackRate > PlayerStats.attackRate)
        {
            attackRate.text = "Attack Rate+";
            attackRate.color = positive;
        }
        else if (StatString.attackRate < PlayerStats.attackRate)
        {
            attackRate.text = "Attack Rate-";
            attackRate.color = negative;
        }
        else
        {
            attackRate.text = "Attack Rate";
            attackRate.color = neutral;
        }

        if (StatString.speed > PlayerStats.speed)
        {
            speed.text = "Speed+";
            speed.color = positive;
        }
        else if (StatString.speed < PlayerStats.speed)
        {
            speed.text = "Speed-";
            speed.color = negative;
        }
        else
        {
            speed.text = "Speed";
            speed.color = neutral;
        }

        if (StatString.resolve > PlayerStats.resolve)
        {
            resolve.text = "Resolve+";
            resolve.color = positive;
        }
        else if (StatString.resolve < PlayerStats.resolve)
        {
            resolve.text = "Resolve-";
            resolve.color = negative;
        }
        else
        {
            resolve.text = "Resolve";
            resolve.color = neutral;
        }

        if (StatString.range > PlayerStats.range)
        {
            range.text = "Range+";
            range.color = positive;
        }
        else if (StatString.range < PlayerStats.range)
        {
            range.text = "Range-";
            range.color = negative;
        }
        else
        {
            range.text = "Range";
            range.color = neutral;
        }

        weaponName.text = StatString.weaponName;
        rarity.text = StatString.rarity;
        flavorText.text = StatString.flavorText;
    }
}
