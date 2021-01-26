using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickWatcher : MonoBehaviour
{

    public Collider2D DTrigger;
    public Collider2D LTrigger;
    public Collider2D RTrigger;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DTrigger.isTrigger = false;
        LTrigger.isTrigger = false;
        RTrigger.isTrigger = false;

        if (GameObject.FindGameObjectsWithTag("Weapon4").Length <= 0)
        {
            DTrigger.isTrigger = true;
            LTrigger.isTrigger = true;
            RTrigger.isTrigger = true;
        }
    }
}
