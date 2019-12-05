using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    public Transform dropLocation;

    /*private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }*/
    public void SpawnDroppedItem()
    {
        Instantiate(item, dropLocation.position, Quaternion.identity);
    }
}
