using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneLoading : MonoBehaviour
{
    public static bool Level1;

    public Image floorClearAgnes1;
    public Image floorClearAgnes2;

    public SceneChanger sceneChanger;

    public void Update()
    {
        if(floorClearAgnes1 != null && floorClearAgnes2 != null)
        {
            if (Level1 == true)
            {
                if (floorClearAgnes1 != null && floorClearAgnes2 != null)
                {
                    floorClearAgnes1.enabled = false;
                    floorClearAgnes2.enabled = true;
                }
            }
            else
            {
                if (floorClearAgnes1 != null && floorClearAgnes2 != null)
                {
                    floorClearAgnes1.enabled = true;
                    floorClearAgnes2.enabled = false;
                }
            }
        }
    }

    public void LoadNextLevel()
    {
        if (Level1 == false)
        {
            sceneChanger.FadeToLevel(3);
        }
        else
        {
            sceneChanger.FadeToLevel(4);
        }
    }

    public void CloseGame()
    {
        Application.Quit();
    }
   
    public void GiveUp()
    {
        SceneManager.LoadScene("GameOver");
    }
}
