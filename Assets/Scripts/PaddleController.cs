using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey, downKey;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
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

        //speedcheck
        if (speed > 6)
        {
            StartCoroutine(SpeedCheck());
        }
    }

    IEnumerator SpeedCheck()
    {
        yield return new WaitForSeconds(5);
        speed = 6;
    }

    public void increaseLenghtPaddle(float longAddedValue)
    {
        //change left paddle localscale
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * longAddedValue, transform.localScale.z);

        //change default value
        StartCoroutine(CompletePowerUp(2));
    }

    IEnumerator CompletePowerUp(float longAddedValue)
    {
        yield return new WaitForSeconds(5);

        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / longAddedValue, transform.localScale.z);
    }
}
