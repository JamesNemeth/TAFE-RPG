using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour
{
	public Image icon;          // Reference to the Icon image
    public Button removeButton; // Reference to the remove button
    public int itemId = 0;

    Item item;  // Current item in the slot

    public GameObject inventroySlot;

    // Add item to the slot
    public void AddItem(Item newItem)
    {
        item = newItem;

        LinearInventory.inv.Add(ItemData.CreateItem(itemId));

        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    // Clear the slot
    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    // Called when the remove button is pressed
    public void OnRemoveButton()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;

        Destroy(gameObject);
    }

}
