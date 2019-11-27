using System.Collections;
using UnityEngine;

public class Interact : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            Ray interactionRay;
            interactionRay = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            RaycastHit hitInfo;
            if(Physics.Raycast(interactionRay, out hitInfo, 10))
            {
                switch(hitInfo.collider.tag)
                {
                    case "NPC":
                        DialogueOption dlg = hitInfo.transform.GetComponent<DialogueOption>();
                        if(dlg != null)
                        {
                            dlg.showDlg = true;

                            Time.timeScale = 0;

                            Cursor.visible = true;
                            Cursor.lockState = CursorLockMode.None;
                        }
                        Debug.Log("NPC Interaction");
                    break;
                    case "Item":
                        Debug.Log("Picked up Item");
                        ItemHandler handler = hitInfo.transform.GetComponent<ItemHandler>();
                            if(handler != null)
                        {
                            handler.OnCollection();
                        }
                    break;

                }
            }
        }
    }
}
