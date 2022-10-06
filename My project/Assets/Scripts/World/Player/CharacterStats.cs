using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [Header("��������������")]
    [SerializeField] private string[] characteristicsName;
    [SerializeField] private int[] characteristicsNumber;

    [Header("�����")]
    [SerializeField] private string[] skillName;
    [SerializeField] private int[] skillLevel;


    //��������� � ���������������
    public void AddStats(int value, int id, int maxOfTeaacher)
    {
        if (maxOfTeaacher >= characteristicsNumber[id] + value)
            characteristicsNumber[id] += value;
        else
            return;//��� �� �������, � ����� ����� �� ���� ���� �������
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
