using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtons : MonoBehaviour
{
    public void ChangeScene(int sceneIndex)
    {
        // whatever button this is on, you can change to any scene in the game
        SceneManager.LoadScene(sceneIndex);
    }
    public void QuitGame()
    {
        // this allows you to quit the application when the quit button is pressed
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
    public void Slot(int slotNum)
    {
        // Depending on whichslot is pressed, the players data is saved to that slot
        PlayerDataToSave.saveSlot = slotNum;
    }
}
