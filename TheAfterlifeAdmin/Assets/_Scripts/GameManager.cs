using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] SinType currentsin;
    [SerializeField] int sinValue;
    public NPC_CharacterDataSO currentCharacter;

    void Update()
    {
        TempInputs();
    }

    public void CharacterJudgement(NPC_CharacterDataSO character)
    {
        Debug.Log(currentCharacter.firstName + " " + currentCharacter.lastName + " has been shipped!");
        Debug.Log(currentCharacter.GetSinStats());

        int positiveSinCount = 0;
        int negativeSinCount = 0;
        int[] sinValues = new int[] { currentCharacter.pride, currentCharacter.greed, currentCharacter.lust, currentCharacter.envy, currentCharacter.gluttony, currentCharacter.wrath, currentCharacter.sloth };
        foreach (int value in sinValues)
        {
            if (value > 0) positiveSinCount++;
            else negativeSinCount++;
        }

        if (positiveSinCount > negativeSinCount)
        {
            Debug.Log("This character is going to heaven!");
            Debug.Log("This character sins count is " + positiveSinCount + " positive sins and " + negativeSinCount + " negative sins.");
        }
        else
        {
            Debug.Log("This character is going to hell!");
            Debug.Log("This character sins count is " + positiveSinCount + " positive sins and " + negativeSinCount + " negative sins.");
        }
        currentCharacter = null;
    }
    #region TempInputs
    void TempInputs()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentsin = SinType.Pride;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentsin = SinType.Greed;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentsin = SinType.Lust;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentsin = SinType.Envy;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentsin = SinType.Gluttony;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            currentsin = SinType.Wrath;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            currentsin = SinType.Sloth;
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            sinValue = 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sinValue = 1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            sinValue = -1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentCharacter.ModifySinValue(currentsin, sinValue);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CharacterJudgement(currentCharacter);
        }
    }
    #endregion
}
