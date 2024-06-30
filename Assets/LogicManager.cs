using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        PlayerScore += 1;
        ScoreText.text = PlayerScore.ToString();
    }
}
