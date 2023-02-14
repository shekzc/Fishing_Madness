using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountL2 : MonoBehaviour
{
    Text countDownText;
    public static float currentTime = 0f;
    public static float startTime = 45f;
    public GameObject LoseMenuUI;
    //float timer;
    // public static float countDownNumber = 60;
    // Start is called before the first frame update
    void Start()
    {
        //currentTime = startTime;
        Time.timeScale = 1f;
        currentTime = startTime;
        countDownText = GetComponent<Text>();
        countDownText.text = currentTime.ToString();

    }

    // Update is called once per frame
    void Update()
    {

        //timer += Time.deltaTime;
        //if (timer >= 0 && countDownNumber >0)
        //{
        //countDownNumber--;
        //countDownText.text = countDownNumber.ToString();
        //timer = 0;
        //}

        currentTime -= 1 * Time.deltaTime;
        //if (countDownNumber >= 0) {
        countDownText.text = Mathf.Round(currentTime).ToString();
        if (currentTime <= 0)
        {
            currentTime = 0;
            LoseMenuUI.SetActive(true);
            SoundManager.instance.RopeStretch(false);
            Time.timeScale = 0f;
        }
        //}else
        // {
        //countDownNumber = 0;
        //}

        //currentTime -= 1 * Time.deltaTime;
        //countDownText.text = currentTime.ToString();

        //if (currentTime <= 0)
        //{
        //currentTime = 0;
        //}

    }

}
