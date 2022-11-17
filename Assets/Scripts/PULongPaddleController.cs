using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULongPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;

    [Header("Extend the Paddles")]
    public GameObject leftPaddle;
    public GameObject rightPaddle;
    public float longAddedValue;
    //public float intervalPowerUpTime;

    [Header("Interval AutoDestroy")]
    public float timeDestroy;

    private void Start()
    {
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(timeDestroy);
        manager.RemovePowerUp(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            leftPaddle.GetComponent<PaddleController>().increaseLenghtPaddle(longAddedValue);
            rightPaddle.GetComponent<PaddleController>().increaseLenghtPaddle(longAddedValue);

            manager.RemovePowerUp(gameObject);
        }
    }
}
