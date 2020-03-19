using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    bool isEnded = false;
    public GameObject gameOverScreen;
    public Text scoreText;
    int score;

    void Start() {
        score = 0;
        gameOverScreen.SetActive(false);
    }

    public void EndGame() {
        if(!isEnded) {
            isEnded = true;
            gameOverScreen.SetActive(true);
        }
    }

    public void addScore() {
        score++;
        scoreText.text = score.ToString();
    }
}
