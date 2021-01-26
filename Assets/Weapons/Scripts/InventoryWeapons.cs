using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryWeapons : MonoBehaviour
{
    public RectTransform[] inventorySpace = new RectTransform[20];
    public GameObject[] InventoryBlocks = new GameObject[20];
    public int[] rarities = new int[20];

    void Awake()
    {
        for (int i = 0; i < inventorySpace.Length; i++)
        {
            inventorySpace[i] = InventoryBlocks[i].GetComponent<RectTransform>();
        }
    }
}
