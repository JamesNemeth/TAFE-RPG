using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    public Transform dropLocation;

    public void SpawnDroppedItem()
    {
        // when the button that this function that is attached to is clicked, make the that is in the GameObject item slot at dropLocation
        Instantiate(item, dropLocation.position, Quaternion.identity);
    }
}
