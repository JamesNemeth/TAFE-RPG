using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private TestInventory Inventory;
    public GameObject itemButton;


    private void Start()
    {
        // inventory finds the object in the scene with the tag Player and gets the TestInventory component which is a script
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<TestInventory>();
    }
    void OnTriggerEnter(Collider other)
    {
        // the object that is collids with has the correct tag
        if (other.CompareTag("Player"))
        {
            // look through the list that are in the inventory slots
            for (int i = 0; i < Inventory.slots.Length; i++)
            {
                // if there is nothing in them..
                if (Inventory.isFull[i] == false)
                {
                    // make the item appear in the slot and say that there is now an item in it now
                    print("pick Up Item");
                    Inventory.isFull[i] = true;
                    Instantiate(itemButton, Inventory.slots[i].transform, false);
                    // destory the item that you just collided with
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
