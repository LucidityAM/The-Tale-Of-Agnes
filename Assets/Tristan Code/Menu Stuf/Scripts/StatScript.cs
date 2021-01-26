using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatScript : MonoBehaviour
{
    public Slider AtkRate;
    public Slider Strength;
    public Slider Speed;
    public Slider Resolve;
    public Slider Range;

    
    // Start is called before the first frame update
    void Start()
    {
        AtkRate.maxValue = PlayerStats.maxAttackRate;
        Strength.maxValue = PlayerStats.maxStrength;
        Speed.maxValue = PlayerStats.maxSpeed;
        Resolve.maxValue = PlayerStats.maxResolve;
        Range.maxValue = PlayerStats.maxRange;
    }

    // Update is called once per frame
    void Update()
    {
        AtkRate.value = PlayerStats.attackRate + PlayerStats.attackRateModifier;
        Strength.value = PlayerStats.strength + PlayerStats.strengthModifier;
        Speed.value = PlayerStats.speed + PlayerStats.speedModifier;
        Resolve.value = PlayerStats.resolve;
        Range.value = PlayerStats.range;

    }
}
