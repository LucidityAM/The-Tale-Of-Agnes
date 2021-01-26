using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfidenceMeter : MonoBehaviour
{
    public Slider confidenceIndicator;
    public GameObject Happy;
    public GameObject Depressed;

    void Start()
    {
        GameManager.confidenceLevel = 0;
        confidenceIndicator.maxValue = 6;
        confidenceIndicator.minValue = -6;
        confidenceIndicator.value = GameManager.confidenceLevel;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateIndicator();
    }

    private void UpdateIndicator()
    {
        if (GameManager.confidenceLevel > 0 || GameManager.confidenceLevel == 0)
        {
            Depressed.SetActive(false);
            Happy.SetActive(true);
        }
        else if (GameManager.confidenceLevel < 0)
        {
            Happy.SetActive(false);
            Depressed.SetActive(true);
        }

        confidenceIndicator.value = GameManager.confidenceLevel;
    }
}
