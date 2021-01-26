using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenControls : MonoBehaviour
{
    public GameObject ControlScreen;

    private void Start()
    {
        ControlScreen.SetActive(false);
    }
    //Opens Screen
    public void OpenScreen()
    {
        Debug.Log("Bruh");
        ControlScreen.SetActive(true);
    }
    //Closes
    public void CloseScreen()
    {
        ControlScreen.SetActive(false);
    }
}
