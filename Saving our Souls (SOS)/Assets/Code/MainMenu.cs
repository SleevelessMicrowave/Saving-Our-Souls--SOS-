using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void FireEscape()
    {
        Debug.Log("button");
        SceneManager.LoadScene("SampleScene");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    public void Flood()
    {
        SceneManager.LoadScene("Flood");
    }
     
}
