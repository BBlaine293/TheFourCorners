using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDestroy : MonoBehaviour
{
    public GameObject explosion;
    public Transform rocket;
    public float collisionRadius = 0.4f;
    public bool collided = false;
    public LayerMask WhatToCollideWith;

    void FixedUpdate()
    {
        collided = Physics2D.OverlapCircle(rocket.position, collisionRadius, WhatToCollideWith);

        if (collided)
        {
            Instantiate(explosion, rocket.position, transform.rotation = Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
