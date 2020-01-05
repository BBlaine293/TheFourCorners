using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDead : MonoBehaviour
{
    public GameObject gameover;
    public GameObject player;

    void Update()
    {
        if (player.activeSelf == false)
        {
            gameover.SetActive(true);
        }
        else
        {
            gameover.SetActive(false);
        }
    }
}
