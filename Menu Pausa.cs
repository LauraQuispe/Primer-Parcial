using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
   public   GameObject Menupausa;

    // Start is called before the first frame update
    void Pause()
    {
        Time.timeScale = 0;


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
         Menupausa.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

    }

}
