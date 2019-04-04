using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed;

    SpawnProjectile myProjectile;

    float minXPos = -8.25f;
    float maxXPos = 8.25f;

    private void Awake()
    {
        myProjectile = GetComponent<SpawnProjectile>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Fire();
    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal");
        var xPos = transform.position.x + deltaX * movementSpeed * Time.fixedDeltaTime;
        var absxPos = Mathf.Clamp(xPos, minXPos, maxXPos);
        transform.position = new Vector2(absxPos, transform.position.y);
    }

    private void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            myProjectile.Move();
        }
    }
}
