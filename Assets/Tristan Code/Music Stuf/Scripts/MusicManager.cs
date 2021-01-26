using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource LevelMusic;
    public AudioSource DialogueMusic;
    public AudioSource BossMusic;

    public static bool isLevel;
    public static bool isDialogue;
    public static bool isBoss;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isDialogue == true)
        {
            //Debug.Log("InDialogue");
            DialogueMusic.UnPause();
            LevelMusic.Pause();
            BossMusic.Pause();
        }
        else if (isBoss == true)
        {
            //Debug.Log("InBoss");
            DialogueMusic.time = 0f;
            BossMusic.UnPause();
            LevelMusic.Pause();
            DialogueMusic.Pause();
        }
        else
        {
            //Debug.Log("InLevel");
            DialogueMusic.time = 0f;
            LevelMusic.UnPause();
            DialogueMusic.Pause();
            BossMusic.Pause();
        }

    }
}
