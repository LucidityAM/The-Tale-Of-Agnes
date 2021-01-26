using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{
    #region Base and Max Stats
    public static float baseAttack = 1f;

    public static float strength = 0f;
    public static float attackRate = 1f;
    public static float speed = 1f;
    public static float resolve = 1f;
    public static float range = 1f;

    public static float maxStrength = 50f;
    public static float maxAttackRate = 6f;
    public static float maxSpeed = 2f;
    public static float maxResolve = 10f;
    public static float maxRange = 1000f;
    #endregion BaseandMaxStats

    public static float currentLevel;
    public static float currentExp;

    public static float strengthModifier;
    public static float attackRateModifier;
    public static float speedModifier;
}
