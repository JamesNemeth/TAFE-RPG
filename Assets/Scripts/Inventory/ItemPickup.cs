using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interact
{
    public int itemId = 0;
    public Item item;   // Item to put in the inventory on pickup

    // When the player interacts with the item
    public override void Interactable()
    {
        base.Interactable();

        PickUp();   // Pick it up!
    }

    // Pick up the item
    void PickUp()
    {
        Destroy(gameObject);
        LinearInventory.inv.Add(ItemData.CreateItem(itemId));   // Add to inventory

        print("Pick Up working");
    }
}
