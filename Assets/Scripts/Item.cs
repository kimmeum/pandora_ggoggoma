using UnityEngine;

public enum ItemType
{
    Equipment,
    Consumables,
    Etc
}

[System.Serializable]
public class Item 
{
    public ItemType itemType;
    public string itemName;
    public Sprite itemImage;
    public bool Use()
    {
        bool isUsed = false;
        isUsed = true;


        return false;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
