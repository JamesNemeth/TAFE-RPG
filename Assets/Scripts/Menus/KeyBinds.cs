using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBinds : MonoBehaviour
{
    public KeyCode forward, backward, left, right, tempKey;
    public Text forwardButton, backwardButton, leftButton, rightButton;

    void Start()
    {
        // this is just for forward but can do the same method for all the buttons
        forward = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Forward", "W"));
        forwardButton.text = forward.ToString();

        backward = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Backward", "S"));
        backwardButton.text = backward.ToString();

        left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left", "A"));
        leftButton.text = left.ToString();

        right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right", "D"));
        rightButton.text = right.ToString();
    }
    public void Forward()
    {
        //if the button is forward key
        if (backward != KeyCode.None || left != KeyCode.None || right != KeyCode.None)
        {
            // Set this key that the function is attached to as the tempKey
            tempKey = forward;
            forward = KeyCode.None;
        }
        forwardButton.text = forward.ToString();
    }
    public void Backward()
    {
        //if the button is back key
        if (forward != KeyCode.None || left != KeyCode.None || right != KeyCode.None)
        {
            // Set this key that the function is attached to as the tempKey
            tempKey = backward;
            backward = KeyCode.None;
        }
        backwardButton.text = backward.ToString();
    }
    public void Left()
    {
        //if the button is left key
        if (right != KeyCode.None || forward != KeyCode.None || backward != KeyCode.None)
        {
            // Set this key that the function is attached to as the tempKey
            tempKey = left;
            left = KeyCode.None;
        }
        leftButton.text = left.ToString();
    }
    public void Right()
    {
        //if the button is right key
        if (left != KeyCode.None || forward != KeyCode.None || backward != KeyCode.None)
        {
            // Set this key that the function is attached to as the tempKey
            tempKey = right;
            right = KeyCode.None;
        }
        rightButton.text = right.ToString();
    }
    private void OnGUI()
    {
        Event e = Event.current;
        if(forward == KeyCode.None)
        {
            //if the button is forward key
            if (e.keyCode != backward || e.keyCode != left || e.keyCode != right)
            {
                // you can set this button as any key 
                forward = e.keyCode;
                forwardButton.text = forward.ToString();
            }
            else
            {
                forward = tempKey;
                forwardButton.text = forward.ToString();

            }
   
        }
        if (backward == KeyCode.None)
        {
            //if the button is backward key
            if (e.keyCode != forward || e.keyCode != left || e.keyCode != right)
            {
                // you can set this button as any key 
                backward = e.keyCode;
                backwardButton.text = backward.ToString();
            }
            else
            {
                backward = e.keyCode;
                backwardButton.text = backward.ToString();

            }

        }
        if (left == KeyCode.None)
        {
            //if the button is left key
            if (e.keyCode != right || e.keyCode != forward || e.keyCode != backward)
            {
                // you can set this button as any key 
                left = e.keyCode;
                leftButton.text = left.ToString();
            }
            else
            {
                left = e.keyCode;
                leftButton.text = left.ToString();

            }

        }
        if (right == KeyCode.None)
        {
            //if the button is right key
            if (e.keyCode != left || e.keyCode != forward || e.keyCode != backward)
            {
                // you can set this button as any key 
                right = e.keyCode;
                rightButton.text = right.ToString();
            }
            else
            {
                right = e.keyCode;
                rightButton.text = right.ToString();
            }
        }
    }
}
