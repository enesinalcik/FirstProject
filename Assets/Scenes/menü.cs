using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menü : MonoBehaviour
{

    public string oyun;


    public void sahne1()
    {
        SceneManager.LoadScene(oyun);

    }
    public void çıkış()
    {
        Application.Quit();

    }

}
