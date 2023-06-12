using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public int id;
    public string icon;
    public string title;
    public string desc;
    public int price;
}

[System.Serializable]
public class ItemList
{
    public Item[] items;
}