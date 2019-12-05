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

    public void Start()
    {
        icon.enabled = true;
    }
    // Add item to the slot
    public void AddItem(Item newItem)
    {
        item = newItem;

        LinearInventory.inv.Add(ItemData.CreateItem(itemId));

        icon.enabled = false;
        removeButton.interactable = true;
    }


    // Called when the remove button is pressed
    public void OnRemoveButton()
    {
        item = null;

        icon.enabled = false;
        removeButton.interactable = false;

        Destroy(gameObject);
    }

}
