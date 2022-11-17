using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;

    [Header("Speed Up Paddles")]
    public GameObject leftPaddle;
    public GameObject rightPaddle;
    public int speedAddedValue;
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
            leftPaddle.GetComponent<PaddleController>().speed *= speedAddedValue;
            rightPaddle.GetComponent<PaddleController>().speed *= speedAddedValue;

            manager.RemovePowerUp(gameObject);
        }
    }
}
