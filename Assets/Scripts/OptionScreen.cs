using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionScreen : MonoBehaviour
{
    public string MainMenu;

    public void QuitToMenu()
    {
        Application.LoadLevel(MainMenu);
    }
}
