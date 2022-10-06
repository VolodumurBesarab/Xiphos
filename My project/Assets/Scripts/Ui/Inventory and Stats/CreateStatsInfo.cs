using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreateStatsInfo : MonoBehaviour
{
    [SerializeField] private GameObject statsText;
    [SerializeField] private CharacterStats playerCharacterStats;

    [Header("Налаштування Тексту")]
    [SerializeField] private int textSize = 25;
    [SerializeField] private Color color = Color.white;

    private void Awake()
    {
        CreateStatsInfoField();
    }

    public void CreateStatsInfoField()
    {
        for (int i = 0; i < playerCharacterStats.GiveCharacteristicsLeanth(); i++)
        {
            Instantiate(statsText, this.transform);
        }
        SetStatsInfo();
    }
    public void SetStatsInfo()
    {
        for (int i = 0; i < playerCharacterStats.GiveCharacteristicsLeanth(); i++)
        {
            this.GetComponentsInChildren<Text>()[i].text = playerCharacterStats.GiveCharacteristicsNaneInfo(i) + " " + playerCharacterStats.GiveCharacteristicsNumberInfo(i);
            this.GetComponentsInChildren<Text>()[i].fontSize = textSize;
            this.GetComponentsInChildren<Text>()[i].color = color;
        }
    }
    /*
    public void ClearAllText()
    {
        for (int i = 0; i<transform.childCount; i++)
        {
            Destroy(this.GetComponentInChildren<GameObject>().gameObject);
        }
    */

}


