using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public string MainMenu;
    public bool isPaused;
    public GameObject pausemenu;



    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            pausemenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pausemenu.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        



    }
    
    public void Resume()
    {
        isPaused = false;
    }

    public void Quit()
    {
        Application.LoadLevel(MainMenu);
    }


}
