using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WristRocket : MonoBehaviour
{
    
    public GameObject RocketPrefab;
    public Transform RocketSpawn;
    public float fireTime = 0.5f;

    public int rocketAmmo = 2;

    private bool isFiring = false;
    private void SetFiring()
    {
        isFiring = false;
    }
    private void Fire()
    {
        if (rocketAmmo <= 0)
        {
            return;
        }

        rocketAmmo--;

        isFiring = true;
        Instantiate(RocketPrefab, RocketSpawn.position, RocketSpawn.rotation);
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
        Invoke("SetFiring", fireTime);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!isFiring)
            {
                Fire();
            }

        }
    }
}