using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    //bool to determine if you already triggered this
    private bool hasCollided;
    public Dialogue dialogue;

    //starts dialogue
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }


    public void Start()
    {
        hasCollided = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if (hasCollided == false)
            {
                hasCollided = true;
                TriggerDialogue();
            }
        }
    }
}
