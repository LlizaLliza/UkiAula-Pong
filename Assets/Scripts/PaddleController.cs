using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey, downKey;

    private Rigidbody2D rb;

    private void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // move object 
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rb.velocity = movement;
        Debug.Log("TEST: " + movement);
        //transform.Translate(movement * Time.deltaTime);
    }
}
