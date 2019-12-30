using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string startlevel;
    public string options;

    
    public void StartGame()
    {
        Application.LoadLevel(startlevel);
    }

    public void Options()
    {
        Application.LoadLevel(options);
    }
     
    public void QuitGame()
    {
        Application.Quit();
    }
   
    
}
