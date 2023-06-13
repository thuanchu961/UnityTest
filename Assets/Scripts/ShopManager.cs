using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : Singleton<ShopManager>
{
    public GameObject panelDetail;
    public Transform content;
    /// <summary>
    /// Json reader
    /// </summary>
    public TextAsset json;

    public ItemList itemList = new ItemList();

    /// <summary>
    /// Shelfs
    /// </summary>
    public int totalShelfs;
    public GameObject shelfPrefab;
    int itemPerShelf = 3;


    /// <summary>
    /// Items
    /// </summary>
    public GameObject itemPrefab;
    public int totalItems;
    // Start is called before the first frame update
    void Start()
    {
        itemList = JsonUtility.FromJson<ItemList>(json.text);
        totalItems = itemList.items.Length;
        SpawnShelf();
    }

    void SpawnShelf()
    {
        totalShelfs = totalItems / 3;
  
        for (int i = 0; i < totalShelfs; i++)
        {
            Shelf shelf = Instantiate(shelfPrefab, content.position, Quaternion.identity).GetComponent<Shelf>();
            shelf.transform.SetParent(content);
           
            for (int j = 0; j < itemPerShelf; j++)
            {
                int itemId = (i * itemPerShelf) + j + 1 - 1 ;

                if(itemId > totalItems)
                {
                    return;
                }

                GameObject item = Instantiate(itemPrefab, shelf.slots[j].position, Quaternion.identity);
                item.transform.SetParent(shelf.slots[j]);

                string spritePath = "Images/ShopItems/" + itemList.items[itemId].icon;
                Sprite newSprite = Resources.Load<Sprite>(spritePath);
                item.GetComponent<ItemController>().SetValue(itemList.items[itemId].title, itemList.items[itemId].price.ToString(), newSprite, itemList.items[itemId].desc );
            }

        }
        
    }


}
