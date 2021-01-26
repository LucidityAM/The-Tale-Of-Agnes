using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuConfidence : MonoBehaviour
{
    public Slider MeterI;
    public Slider MeterS;
    public Slider MeterSY;

    public GameObject HappyI;
    public GameObject DepressedI;
    public GameObject HappyS;
    public GameObject DepressedS;
    public GameObject HappySY;
    public GameObject DepressedSY;

    public Text CurrentLevelI;
    public Text CurrentLevelS;
    public Text CurrentLevelSY;


    // Start is called before the first frame update
    void Start()
    {
        MeterI.maxValue = 100;
        MeterS.maxValue = 100;
        MeterSY.maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        MeterI.value = (float)GameManager.confidenceLevel * 16.9f;
        MeterS.value = (float)GameManager.confidenceLevel * 16.9f;
        MeterSY.value = (float)GameManager.confidenceLevel * 16.9f;

        if (MeterS.value < 0 || MeterS.value < 0 || MeterSY.value < 0)
        {
            DepressedS.SetActive(true);
            DepressedI.SetActive(true);
            DepressedSY.SetActive(true);

            HappyS.SetActive(false);
            HappyI.SetActive(false);
            HappySY.SetActive(false);
        }
        else
        {
            DepressedS.SetActive(false);
            DepressedI.SetActive(false);
            DepressedSY.SetActive(false);

            HappyS.SetActive(true);
            HappyI.SetActive(true);
            HappySY.SetActive(true);
        }

        CurrentLevelI.text = "Level " + PlayerStats.currentLevel;
        CurrentLevelS.text = "Level " + PlayerStats.currentLevel;
        CurrentLevelSY.text = "Level " + PlayerStats.currentLevel;
    }
}
