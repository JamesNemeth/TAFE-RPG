using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private TestInventory Inventory;
    public GameObject itemButton;


    private void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<TestInventory>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < Inventory.slots.Length; i++)
            {
                if (Inventory.isFull[i] == false)
                {
                    print("pick Up Item");
                    Inventory.isFull[i] = true;
                    Instantiate(itemButton, Inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
