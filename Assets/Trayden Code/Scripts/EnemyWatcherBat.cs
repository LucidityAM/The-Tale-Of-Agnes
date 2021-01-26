using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWatcherBat : MonoBehaviour
{
    public Collider2D DTrigger;
    public Collider2D UTrigger;
    public Collider2D LTrigger;
    public Collider2D RTrigger;
    public GameObject Enemy;
    public GameObject Shooter;
    // Start is called before the first frame update
    void Start()
    {
        Enemy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Bat").Length <= 0 && GameObject.FindGameObjectsWithTag("Bat1").Length <= 0)
        {
            DTrigger.isTrigger = true;
            UTrigger.isTrigger = true;
            LTrigger.isTrigger = true;
            RTrigger.isTrigger = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Enemy != null)
        {
            if (collision.gameObject.tag == "player")
            {
                Enemy.SetActive(true);
                Shooter.GetComponent<EnemyShoot>().enabled = false;
                DTrigger.isTrigger = false;
                UTrigger.isTrigger = false;
                LTrigger.isTrigger = false;
                RTrigger.isTrigger = false;
                this.GetComponent<BoxCollider2D>().enabled = false;
                StartCoroutine("Activate");
            }
        }
    }

    IEnumerator Activate()
    {
        yield return new WaitForSeconds(1);
        Shooter.GetComponent<EnemyShoot>().enabled = true;
    }
}
