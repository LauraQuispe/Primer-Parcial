using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Abrirmenu : MonoBehaviour
{
    [SerializeField] GameObject Menupausa;

    int SampleScene;


    public void Pause()
    {
        Menupausa.SetActive(true);
        Time.timeScale = 0;
    }


    public void Resume()
    {
        Menupausa.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Home(int SceneID)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneID);
    }
}