using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitCode : MonoBehaviour
{
    public float wait_time = 63f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait_for_Intro());
    }

    IEnumerator Wait_for_Intro()
    {
        yield return new WaitForSeconds(wait_time);

        SceneManager.LoadScene("SampleScene");
    }

}
