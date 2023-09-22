using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ConsumbleType
{
    Axe,
    Club,
    Spear,
    Staff,
    WateringCan,
    FishingRods
}

[System.Serializable]
public class ItemDataConsumable
{
    public ConsumbleType type;
    public float value;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;
}

