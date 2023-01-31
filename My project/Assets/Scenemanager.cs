using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    void Update()
    {

    {
        if (Input.GetKeyDown("n"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKeyDown("m"))
        {
            SceneManager.LoadScene("SecondScene");
        }
    }


    }
}
