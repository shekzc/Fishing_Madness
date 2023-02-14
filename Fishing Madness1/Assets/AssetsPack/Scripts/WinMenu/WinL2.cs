using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinL2 : MonoBehaviour
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
        SceneManager.LoadScene("EndCredit");
        WinmenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Retry()
    {
        SceneManager.LoadScene("Level2");
        WinmenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Next()
    {
        SceneManager.LoadScene("EndCredit");
        WinmenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
