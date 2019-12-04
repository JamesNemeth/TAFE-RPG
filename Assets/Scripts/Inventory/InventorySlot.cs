using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour
{
    public RawImage icon;          // Reference to the Icon image
    public Button removeButton; // Reference to the remove button
    public int itemId = 0;

    Item item;  // Current item in the slot

    public GameObject inventroySlot;

    // Add item to the slot
    public void AddItem(Item newItem)
    {
        item = newItem;

        LinearInventory.inv.Add(ItemData.CreateItem(itemId));

        icon.texture = item.icon.texture;
        icon.enabled = true;
        removeButton.interactable = true;
    }


    // Called when the remove button is pressed
    public void OnRemoveButton()
    {
        item = null;

        icon.texture = null;
        icon.enabled = false;
        removeButton.interactable = false;

        Destroy(gameObject);
    }

}
