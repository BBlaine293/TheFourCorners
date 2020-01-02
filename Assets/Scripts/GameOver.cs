using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public string MainMenu;
    public string startlevel;
    public bool isDead;
    public GameObject gameover;

   

        public void Restart()
    {
        Application.LoadLevel(startlevel);
    }

   

    public void QuitToMenu()
    {
        Application.LoadLevel(MainMenu);
    }
}
