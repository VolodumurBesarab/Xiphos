using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stats : MonoBehaviour
{
    //[Header("Характеристики")]
    [SerializeField] private GameObject statsText;
    [SerializeField] private string[] playerStatsName;
    [SerializeField] private int[] playerStatsValue;
    public int Strange { set; get; }
    public int Agility { set; get; }
    public int Health { set; get; }

    private void Awake()
    {
        SetStats();
        AddField();
    }
    
    private void AddField()
    {
        for(var i = 0; i < playerStatsValue.Length; i++)
        {
            Instantiate(statsText, this.transform);
            this.GetComponentsInChildren<Text>()[i].text = playerStatsName[i] + " " + playerStatsValue[i];
            
        }
    }

    private void SetStats()
    {
        Strange = 100;
        Agility = 100;
        Health = 200;
        playerStatsValue[0] = Strange;
        playerStatsValue[1] = Agility;
        playerStatsValue[2] = Health;
    }
}
