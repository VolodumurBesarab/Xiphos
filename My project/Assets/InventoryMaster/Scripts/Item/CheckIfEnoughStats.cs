using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfEnoughStats : MonoBehaviour
{
    CharacterStats characterStats;
    public bool IsEnoughStrange(Item item)
    {
        for (int i = 0; i < item.itemAttributes.Count; i++)
            if (item.itemAttributes[i].attributeName == "Strange")
                if (item.itemAttributes[i].attributeValue <= characterStats.GiveCharacteristicsNumberInfo(0))
                    return true;
                else
                    return false;
        return true;
    }
    /*
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
