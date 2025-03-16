using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum SinType
{
    Pride,
    Greed,
    Lust,
    Envy,
    Gluttony,
    Wrath,
    Sloth
}
[CreateAssetMenu(fileName = "NewCharacter", menuName = "Character Data")]
public class NPC_CharacterDataSO : ScriptableObject
{
    public string firstName;
    public string lastName;
    public string gender;
    public int age;
    public string causeOfDeath;

    private const int MinSinValue = -5;
    private const int MaxSinValue = 5;
    [Range(MinSinValue, MaxSinValue)]
    public int pride;
    [Range(MinSinValue, MaxSinValue)]
    public int greed;
    [Range(MinSinValue, MaxSinValue)]
    public int lust;
    [Range(MinSinValue, MaxSinValue)]
    public int envy;
    [Range(MinSinValue, MaxSinValue)]
    public int gluttony;
    [Range(MinSinValue, MaxSinValue)]
    public int wrath;
    [Range(MinSinValue, MaxSinValue)]
    public int sloth;

    public void ModifySinValue(SinType sin, int value)
    {
        switch (sin)
        {
            case SinType.Pride:
                pride += value;
                pride = Mathf.Clamp(pride, MinSinValue, MaxSinValue);
                break;
            case SinType.Greed:
                greed += value;
                greed = Mathf.Clamp(greed, MinSinValue, MaxSinValue);
                break;
            case SinType.Lust:
                lust += value;
                lust = Mathf.Clamp(lust, MinSinValue, MaxSinValue);
                break;
            case SinType.Envy:
                envy += value;
                envy = Mathf.Clamp(envy, MinSinValue, MaxSinValue);
                break;
            case SinType.Gluttony:
                gluttony += value;
                gluttony = Mathf.Clamp(gluttony, MinSinValue, MaxSinValue);
                break;
            case SinType.Wrath:
                wrath += value;
                wrath = Mathf.Clamp(wrath, MinSinValue, MaxSinValue);
                break;
            case SinType.Sloth:
                sloth += value;
                sloth = Mathf.Clamp(sloth, MinSinValue, MaxSinValue);
                break;
        }
    }
    public string GetSinStats()
    {
        return $"Sins: Pride: {pride}, Greed: {greed}, Lust: {lust}, Envy: {envy}, Gluttony: {gluttony}, Wrath: {wrath}, Sloth: {sloth}\n";
    }
}
