using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public Camera cam;

    public float moveX = 0.7f;

    public float moveY = 0.7f;

    public float movespeed = 2f;

    float height;

    float width;

    Vector2 playerPos;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.FindGameObjectsWithTag("Player")[0].transform.position;
    }

    void FixedUpdate()
    {
        if (rb.position.x > -2 && rb.position.x < 2)
        {
            movement.x += UnityEngine.Random.Range(-moveX, moveX);
        }
        if (rb.position.y > -2 && rb.position.y < 2)
        {
            movement.y += UnityEngine.Random.Range(-moveY, moveY);
        }
        UnityEngine.Debug.Log(rb.position);
        if (rb.position.x > 2)
        {
            movement.x -= UnityEngine.Random.Range(0, 2 );
        }
        if (rb.position.x < -2)
        {
            movement.x += UnityEngine.Random.Range(0, 2);
        }
        if (rb.position.y > 2)
        {
            movement.y -= UnityEngine.Random.Range(0, 2);
        }
        if (rb.position.y < -2)
        {
            movement.y += UnityEngine.Random.Range(0, 2);
        }


        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);

        Vector2 lookDir = playerPos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + -90f;

        rb.rotation = angle;
    }
}
