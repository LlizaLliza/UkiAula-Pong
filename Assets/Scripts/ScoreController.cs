using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorKiri, skorKanan;

    public ScoreManager scoreManager;
    
    // Update is called once per frame
    void Update()
    {
        skorKiri.text = scoreManager.leftScore.ToString();
        skorKanan.text = scoreManager.rightScore.ToString();
    }
}
