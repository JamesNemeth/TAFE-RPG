
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;   // The parent object of all the items
    public GameObject inventoryUI;  // The entire UI

    public int itemId = 0;

    LinearInventory inventory;    // Our current inventory

    public InventorySlot[] slots;  // List of all the slots

    void Start()
    {
        // Populate our slots array
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }


    private void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        // Loop through all the slots
        for (int i = 0; i < slots.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (i < LinearInventory.inv.Count)  // If there is an item to add
                {
                    slots[i].AddItem(LinearInventory.inv[i]);
                    LinearInventory.inv.Add(ItemData.CreateItem(itemId));// Add it
                }
                else
                {
                    // Otherwise clear the slot
                    slots[i].OnRemoveButton();
                }
            }
        }
    }
}
