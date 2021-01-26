using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapIndicator : MonoBehaviour
{
    public GameObject player;
    public GameObject Reticle;
    public GameObject minimap;

    //Multiplier go woo
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Reticle.transform.localPosition = new Vector3(player.transform.position.x * speed, player.transform.position.y * speed, 15);
    }

    // Update is called once per frame
    void Update()
    {
        Reticle.transform.localPosition = new Vector3(player.transform.position.x * speed, player.transform.position.y * speed, 15); 
    }
}
