using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickTitleScene : MonoBehaviour
{
    public Texture backgroundTexture;
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);
        if (Input.anyKeyDown)
        {
            Debug.Log("A key or mouse click has been detected");
            
            SceneManager.LoadScene("BrickScene");
        }
    }
}
