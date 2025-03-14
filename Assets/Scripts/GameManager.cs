using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dictionary<int, string> materialDict = new Dictionary<int, string>();
    public Dictionary<int, string> armorTypeDict = new Dictionary<int, string>();
    public Dictionary<int, string> weaponTypeDict = new Dictionary<int, string>();
    public Dictionary<int, string> potionEffectDict = new Dictionary<int, string>();
    public Item chosenItem { 
        get { return chosenItem; } 
        set { 
            chosenItem = value;
            UpdatePreview(chosenItem);
        } 
    }
    public GameObject itemDetails;
    [Header("Material List")]
    public string[] materialArray;
    [Header("ArmorPiece List")]
    public string[] armorPieceArray;
    [Header("WeaponType List")]
    public string[] weaponTypeArray;
    [Header("PotionEffect List")]
    public string[] potionEffectArray;

    private void Start()
    {
        materialDict = InitiateDictionaryWithArray(materialArray);
        armorTypeDict = InitiateDictionaryWithArray(armorPieceArray);
        weaponTypeDict = InitiateDictionaryWithArray(weaponTypeArray);
        potionEffectDict = InitiateDictionaryWithArray(potionEffectArray);

        //foreach (KeyValuePair<int, string> kvp in weaponTypeDict)
        //{
        //    Debug.Log(kvp);
        //}
    }
    private void UpdatePreview(Item chosenItem)
    {
        throw new NotImplementedException();
    }
    public string FirstLetterToUpper(string str)
    {
        if (str == null)
        {
            return null;
        }

        if (str.Length > 1)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        return str.ToUpper();
    }

    public string SplitAtUpperCase(string str)
    {
        string res = "";
        string[] split = Regex.Split(str, @"(?<!^)(?=[A-Z])");
        for (int i = 0; i < split.Length; i++)
        {
            res += " " + split[i];
        }
        return res;
    }

    private Dictionary<int, string> InitiateDictionaryWithArray(string[] array)
    {
        Dictionary<int, string> newDictionary = new Dictionary<int, string>();

        for (int i = 0; i < array.Length; i++)
        {
            string newEntry = array[i];
            if (!newDictionary.ContainsValue(newEntry))
            {
                newDictionary.Add(i, SplitAtUpperCase(FirstLetterToUpper(newEntry)));
            }
        }

        return newDictionary;
    }
}
