using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void BtnStart()
    {
        SceneManager.LoadScene("VisualNovelPart1");
    }

    public void BtnRestart()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BtnQuit()
    {
        Application.Quit();
    }
}
