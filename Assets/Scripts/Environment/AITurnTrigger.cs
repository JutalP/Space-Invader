﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITurnTrigger : MonoBehaviour
{
    Enemy myEnemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myEnemy = collision.gameObject.GetComponent<Enemy>();

        if (myEnemy.bIsMovingLeft)
        {
            myEnemy.bIsMovingLeft = false;
            myEnemy.bIsMovingRight = true;
        }

        else if (myEnemy.bIsMovingRight)
        {
            myEnemy.bIsMovingRight = false;
            myEnemy.bIsMovingLeft = true;
        }
    }
}