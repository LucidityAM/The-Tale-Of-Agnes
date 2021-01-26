using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemDrops : MonoBehaviour
{
    public GameObject[] weapons = new GameObject[9];

    public int[] table = {12, 9, 16, 14, 19, 10, 8, 6, 6 };

    public Transform spawnLoc;

    public int total;
    public int randomNumber;
    public void RandomDrop()
    {
        foreach (var item in table )
        {
            total += item;
        }

        randomNumber = Random.Range(0, total);

        for(int i = 0; i < table.Length; i++)
        {
            if (Ristatic.pickedUp[i] == false)
            {
                if (randomNumber <= table[i])
                {
                    Ristatic.pickedUp[i] = true;
                    Instantiate(weapons[i], spawnLoc.transform);
                    break;
                }
                else
                {
                    randomNumber -= table[i];
                }
            }
            
        }
    }
}
