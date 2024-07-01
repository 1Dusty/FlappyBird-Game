using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public GameObject GameOverScreen;
    [ContextMenu("Increase Score")]
    public void AddScore(int Value)
    {
        PlayerScore += Value;
        ScoreText.text = PlayerScore.ToString();
    }
    [ContextMenu("Restart")]
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    [ContextMenu("GameOver")]
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
