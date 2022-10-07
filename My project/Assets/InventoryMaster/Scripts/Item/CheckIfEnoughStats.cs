using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfEnoughStats : MonoBehaviour
{
    [SerializeField]
    CharacterStats characterStats;
    

    public bool IsEnoughStrange(Item item)
    {
        bool isEnough = true;
        if (item.itemType == ItemType.Weapon)
        {
            for (int i = 1; i < item.itemAttributes.Count; i++)
                if (item.itemAttributes[i].attributeName == "Сила")
                    if (item.itemAttributes[i].attributeValue <= characterStats.GiveCharacteristicsValue(0))
                    {
                        Debug.Log("Need Strange " + item.itemAttributes[i].attributeValue);
                        Debug.Log("Have Strange " + characterStats.GiveCharacteristicsValue(0));
                        isEnough = true;
                    }
                    else
                    {
                        Debug.Log("Need Strange " + item.itemAttributes[i].attributeValue);
                        Debug.Log("Have Strange " + characterStats.GiveCharacteristicsValue(0));
                        isEnough = false;
                    }
        }
        return isEnough;
    }

    /*
    public bool IsEnoughStrange(Item item)
    {
        for (int i = 0; i < item.itemAttributes.Count; i++)
            if (item.itemAttributes[i].attributeName == "Strange")
                if (item.itemAttributes[i].attributeValue <= characterStats.GiveCharacteristicsValueInfo(0))
                    return true;
                else
                    return false;
        return true;
    }
     * 
     * 
    public void OnUnEquipItem(Item item)
    {
        for (int i = 0; i < item.itemAttributes.Count; i++)
        {
            if (item.itemAttributes[i].attributeName == "Health")
                maxHealth -= item.itemAttributes[i].attributeValue;
            if (item.itemAttributes[i].attributeName == "Mana")
                maxMana -= item.itemAttributes[i].attributeValue;
            if (item.itemAttributes[i].attributeName == "Armor")
                maxArmor -= item.itemAttributes[i].attributeValue;
            if (item.itemAttributes[i].attributeName == "Damage")
                maxDamage -= item.itemAttributes[i].attributeValue;
        }
    }
    */
    //if (HPMANACanvas != null)
    //{
    //    UpdateManaBar();
    //    UpdateHPBar();
    //}
}
