using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour
{
    public static bool BossStart;
    public GameObject bossHealthBar;
    public BossAttacks bossAttacks;

    private void Start()
    {
        BossStart = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (BossStart == true && BossAttacks.defeatedRuby == false && BossAttacks.defeatedStripes == false)
        {
            bossHealthBar.SetActive(true);
            bossAttacks.StartRubyBossFight();
            Destroy(this);
        }
        else if (BossStart == true && BossAttacks.defeatedRuby == true && BossAttacks.defeatedStripes == false)
        {
            bossHealthBar.SetActive(true);
            bossAttacks.StartStripesBossFight();
            Destroy(this);
        }
        else if (BossStart == true && BossAttacks.defeatedRuby == true && BossAttacks.defeatedStripes == true)
        {
            bossHealthBar.SetActive(true);
            bossAttacks.StartDragonBossFight();
            Destroy(this);
        }
        else
        {
            bossHealthBar.SetActive(false);
            MusicManager.isBoss = false;
        }

    }
}
