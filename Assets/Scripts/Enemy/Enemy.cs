using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementSpeed = 2f;

    AITurnTrigger myTurnTrigger;
    Rigidbody2D myRigidbody;
    float minXPos = -8.25f;
    float maxXPos = 8.25f;
    public bool bIsMovingLeft = false;
    public bool bIsMovingRight = false;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        bIsMovingLeft = true;
    }

    private void Update()
    {
        if(bIsMovingLeft)
            myRigidbody.velocity = new Vector2(-movementSpeed * Time.fixedDeltaTime, 0);

        else if(bIsMovingRight)
            myRigidbody.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, 0);
    }

    public void FolkesFunktion()
    {
        transform.position += new Vector3(0, -0.2f,0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        myTurnTrigger = collision.gameObject.GetComponent<AITurnTrigger>();

        if(collision.gameObject == myTurnTrigger || collision.gameObject.GetComponent<Enemy>())
        {
            return;
        }
        else
            Destroy(gameObject);
    }
}
