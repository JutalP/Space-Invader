using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITurnTrigger : MonoBehaviour
{
    Enemy myEnemy;
    Enemy[] myEnemyArray;
    public bool bIsLeft;


    private void Start()
    {
        myEnemyArray = GameObject.FindObjectsOfType<Enemy>();
    }

    public void AITurn()
    {
        for (int i = myEnemyArray.Length -1; i >= 0; i--)
        {
            if (bIsLeft && myEnemyArray[i] != null)
            {
                myEnemyArray[i].bIsMovingLeft = false;
                myEnemyArray[i].bIsMovingRight = true;
                myEnemyArray[i].FolkesFunktion();
            }

            else if (!bIsLeft && myEnemyArray[i] != null)
            {
                myEnemyArray[i].bIsMovingRight = false;
                myEnemyArray[i].bIsMovingLeft = true;
                myEnemyArray[i].FolkesFunktion();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.GetComponent<Enemy>())
        //{
            AITurn();
        //}
    }
}
