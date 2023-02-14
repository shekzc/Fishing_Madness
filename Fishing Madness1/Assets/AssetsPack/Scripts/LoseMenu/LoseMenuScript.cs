using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenuScript : MonoBehaviour
{
    public GameObject LoseMenuUI;
    // Start is called before the first frame update

    void Update()
    {
        
    }

    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
        LoseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Back()
    {
        SceneManager.LoadScene("Main_Menu");
        LoseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

}
