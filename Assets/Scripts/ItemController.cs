using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public Text itemName;
    public Text itemPrice;
    public Image itemImage;

    string _name;
    string _price;
    Sprite _image;
    string _desc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Show()
    {
        itemName.text = _name;
        itemPrice.text = _price;
        itemImage.sprite = _image;
    }
    public void SetValue(string name, string price, Sprite image, string desc)
    {
        _name = name;
        _price = price;
        _image = image;
        _desc = desc;

        Show();
    }

    public void ShowDetail()
    {
        ShopManager.Instant.panelDetail.SetActive(true);
        Debug.Log("Name: " + _name + " desc: " + _desc);
        DetailPanelController.Instant.Show(_name, _desc, _image);
        
    }
}
