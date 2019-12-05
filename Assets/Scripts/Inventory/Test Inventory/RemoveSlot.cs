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
        removeButton.interactable = true;
    }
    public void OnRemoveButton()
    {
        removeButton.interactable = false;

        Destroy(gameObject);
    }

}
