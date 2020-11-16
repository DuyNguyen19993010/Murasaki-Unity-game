﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Consumable Object", menuName = "Inventory System/Items/Consumable")]
public class ConsumableObject : ItemObject
{

    public float increaseCurrentHealth;
    public float increaseDamage;
    public void Awake()
    {
        type = ItemType.consumable;
    }
}