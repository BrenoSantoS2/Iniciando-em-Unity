using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
