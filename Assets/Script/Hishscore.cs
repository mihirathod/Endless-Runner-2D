using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Hishscore : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public  float  Score;
    private float Increasepersec;
    private void Start()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
        Increasepersec = 10f;
    }

    private void Update()
    {
        ScoreText.text = "Score:" + (int)Score;
        Score += Increasepersec * Time.deltaTime;
    }
}
