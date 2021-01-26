using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnd : MonoBehaviour
{
    public Dialogue BossbeatDialogue;
    public DialogueManager DialogueManager;

    public GameObject bossHealthBar;

    public Collider2D DTrigger;
    public Collider2D UTrigger;
    public Collider2D LTrigger;
    public Collider2D RTrigger;

    private bool isDone;

    // Start is called before the first frame update
    void Start()
    {
        isDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (BossHealthHolder.bossHealth <= 0f && isDone == false)
        {
            BossTrigger.BossStart = false;
            bossHealthBar.SetActive(false);
            DialogueManager.StartDialogue(BossbeatDialogue);
            MusicManager.isBoss = false;
            isDone = true;
            DTrigger.isTrigger = true;
            UTrigger.isTrigger = true;
            LTrigger.isTrigger = false;
            RTrigger.isTrigger = false;
        }

    }
}
