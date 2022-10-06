using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [Header("Характеристики")]
    [SerializeField] private string[] characteristicsName;
    [SerializeField] private int[] characteristicsNumber;

    [Header("Вміння")]
    [SerializeField] private string[] skillName;
    [SerializeField] private int[] skillLevel;


    //Перенести в статсконтроллер
    public void AddStats(int value, int id, int maxOfTeaacher)
    {
        if (maxOfTeaacher >= characteristicsNumber[id] + value)
            characteristicsNumber[id] += value;
        else
            return;//Нпц має сказати, Я більше нічого не можу тебе навчити
    }
    public int GiveCharacteristicsLeanth()
    {
        return characteristicsName.Length;
    }
    public int GiveCharacteristicsNumberInfo(int i)
    {
        return characteristicsNumber[i];
    }

    public string GiveCharacteristicsNaneInfo(int i)
    {
        return characteristicsName[i];
    }



}
