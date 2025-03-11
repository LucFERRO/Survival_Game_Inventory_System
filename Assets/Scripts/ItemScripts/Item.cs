using UnityEngine;
using UnityEngine.UI;
public class Item : MonoBehaviour
{
    public Sprite sprite;
    public int itemId;
    public string itemName;
    public float weight;
    public bool isStackable;
    public int maxStack;
    public int currentStack;
    public bool isEquipable;
    public int sellingValue;
}
