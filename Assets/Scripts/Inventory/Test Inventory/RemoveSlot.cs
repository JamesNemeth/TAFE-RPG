using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveSlot : MonoBehaviour
{
    public Button removeButton;

    // Start is called before the first frame update
    void Start()
    {
        // the remove button is able to be pressed at the start of the game
        removeButton.interactable = true;
    }
    public void OnRemoveButton()
    {
        // when the button is press, it can no longer be pressed again
        removeButton.interactable = false;
        // destroy ther object that the OnRemoveButton fuunction is on
        Destroy(gameObject);
    }

}
