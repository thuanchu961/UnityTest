using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailPanelController : Singleton<DetailPanelController>
{
    public Text itemName;
    public Text itemDesc;
    public Image itemImage;
 
    public void Show(string name, string desc, Sprite sprite)
    {
        itemName.text = name;
        itemDesc.text = desc;
        itemImage.sprite = sprite;
    }
}
