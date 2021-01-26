using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Map : MonoBehaviour
{
    public GameObject[] GameTiles;
    public GameObject[] MinimapTiles;



    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < MinimapTiles.Length; i++)
        {
            MinimapTiles[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Start Room")
        {
            MinimapTiles[0].SetActive(true);
        }

        if (collision.gameObject.tag == "LD")
        {
            MinimapTiles[1].SetActive(true);
        }
        if (collision.gameObject.tag == "DR")
        {
            MinimapTiles[2].SetActive(true);
        }
        if (collision.gameObject.tag == "TD")
        {
            MinimapTiles[3].SetActive(true);
        }
        if (collision.gameObject.tag == "Treasure")
        {
            MinimapTiles[4].SetActive(true);
        }
        if (collision.gameObject.tag == "TR BIG")
        {
            MinimapTiles[5].SetActive(true);
        }
        if (collision.gameObject.tag == "TLR")
        {
            MinimapTiles[6].SetActive(true);
        }
        if (collision.gameObject.tag == "Rest LR")
        {
            MinimapTiles[7].SetActive(true);
        }
        if (collision.gameObject.tag == "Boss Room")
        {
            MinimapTiles[8].SetActive(true);
        }


    }
}
