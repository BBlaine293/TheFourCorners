﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController2D : MonoBehaviour { 
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;

    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("DashMove");
        }

    }

    IEnumerator DashMove()
    {
        speed += 20;
        yield return new WaitForSeconds(0.25f);
        speed -= 20;
    }
}
