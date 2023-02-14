using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinL1 : MonoBehaviour
{
    //  public static bool gamePaused = false;

    public GameObject WinmenuUI;

    void Update()
    {
        //Back();
        //Retry();
        //Next();
    }

    public void Back()
    {
        SceneManager.LoadScene("Main_Menu");
        WinmenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Retry()
    {
        SceneManager.LoadScene("Level1");
        WinmenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Next()
    {
        SceneManager.LoadScene("Level2");
        WinmenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
