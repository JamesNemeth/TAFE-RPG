using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;

    public Transform dropLocation;
    
    public void SpawnDroppedItem()
    {
        GameObject itemToDrop = Instantiate(item, dropLocation.position, Quaternion.identity);
        //apply gravity and make sure its named correctly 
        itemToDrop.AddComponent<Rigidbody>().useGravity = true;
    }
}
