using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public float confidenceValue;
    public float currentLevel;

    public Text previousLevel;
    public Text currentLevell;
    public Text nextLevel;

    public Text currentLevelSlider;
    public Slider currentLevelSl;

    public Text currentExp;

    public float neededExp;

    public Text attackRate;
    public Text strength;
    public Text speed;

    void Start()
    {

        previousLevel.text = "Level " + PlayerStats.currentLevel.ToString() +" -> ";
        
        confidenceValue = GameManager.confidenceLevel * 8f;

        PlayerStats.currentExp += Mathf.RoundToInt(confidenceValue);

        Debug.Log(PlayerStats.currentExp);

        PlayerStats.currentLevel += Mathf.RoundToInt(confidenceValue) / 5;

        Debug.Log(PlayerStats.currentLevel);

        currentLevell.text = "Level " + PlayerStats.currentLevel.ToString();

        currentExp.text = "Confidence: " + PlayerStats.currentExp.ToString();

        currentLevelSlider.text = "Level " + PlayerStats.currentLevel.ToString();

        nextLevel.text = "Level " + (PlayerStats.currentLevel + 1).ToString();

        currentLevelSl.maxValue = 5;
        neededExp = Mathf.Abs(5 - (PlayerStats.currentExp / PlayerStats.currentLevel)); 
        Debug.Log(neededExp);
        currentLevelSl.value = neededExp;

        PlayerStats.attackRateModifier = PlayerStats.currentLevel * .1f;
        PlayerStats.strengthModifier = PlayerStats.currentLevel * .18f;
        PlayerStats.speedModifier = PlayerStats.currentLevel * .01f;

        Debug.Log(PlayerStats.attackRateModifier);
        Debug.Log(PlayerStats.strengthModifier);
        Debug.Log(PlayerStats.speedModifier);

        attackRate.text = "+" + (PlayerStats.attackRateModifier).ToString();
        strength.text = "+" + (PlayerStats.strengthModifier).ToString();
        speed.text = "+" + (PlayerStats.speedModifier).ToString(); 
    }
}
