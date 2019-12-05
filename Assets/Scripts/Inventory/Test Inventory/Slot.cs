using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private TestInventory inventory;
    public int i;

    private void Start()
    {
        // inventory finds the object in the scene with the tag Player and gets the TestInventory component which is a script
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<TestInventory>();
    }

    private void Update()
    {
        // if there is nothing in the inventory slot
        if ( transform.childCount <= 0)
        {
            // set inventory as false so items may be equipped
            inventory.isFull[i] = false;
        }
    }
    public void DropItem()
    {
        // for each object that is paired to the slot at that loaction
        foreach (Transform child in transform)
        {
            // the object gets the SpawnDroppedItem function
            child.GetComponent<Spawn>().SpawnDroppedItem();
            // will destroy the object
            GameObject.Destroy(child.gameObject);
        }
    }
}
