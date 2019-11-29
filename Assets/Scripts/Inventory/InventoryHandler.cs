using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHandler : MonoBehaviour
{
    public static bool inInventory;
    public GameObject Inventory;
    // Update is called once per frame
    void Start()
    {
        inInventory = false;//not pasued 
        Time.timeScale = 1;//start time
        Cursor.lockState = CursorLockMode.Locked;//lock cursor to cenetr of screen
        Cursor.visible = false;//hide cursor
        Inventory.SetActive(false);//show pause menu

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))//press i
        {
            TogglePause();//runs pause function
        }
    }

    public void TogglePause()
    {
        if (inInventory)//is true if it is active
        {
            Inventory.SetActive(false);//show pause menu
            inInventory = false;//not pasued 
            Time.timeScale = 1;//start time
            Cursor.lockState = CursorLockMode.Locked;//lock cursor to cenetr of screen
            Cursor.visible = false;//hide cursor
        }
        else//is false if it is active
        {

            Inventory.SetActive(true);//hide pause menu
            inInventory = true;//we are pasued
            Time.timeScale = 0;//stop time
            Cursor.lockState = CursorLockMode.None;//allow cursor movement
            Cursor.visible = true;//show cursor
        }
    }
}
