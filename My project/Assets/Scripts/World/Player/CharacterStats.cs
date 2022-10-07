using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [Header("��������������")]
    [SerializeField] private string[] characteristicsName;
    [SerializeField] private int[] characteristicsValue;

    [Header("�����")]
    [SerializeField] private string[] skillName;
    [SerializeField] private int[] skillLevel;


    //��������� � ���������������
    public void AddStats(int value, int id, int maxOfTeaacher)
    {
        if (maxOfTeaacher >= characteristicsValue[id] + value)
            characteristicsValue[id] += value;
        else
            return;//��� �� �������, � ����� ����� �� ���� ���� �������
    }
    public int GiveCharacteristicsLeanth()
    {
        return characteristicsName.Length;
    }
    public int GiveCharacteristicsValue(int i)
    {
        return characteristicsValue[i];
    }

    public string GiveCharacteristicsName(int i)
    {
        return characteristicsName[i];
    }



}
