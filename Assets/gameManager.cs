using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    bool isEnded = false;
    public GameObject gameOverScreen;

    void Start() {
        gameOverScreen.SetActive(false);
    }

    public void EndGame() {
        if(!isEnded) {
            isEnded = true;
            gameOverScreen.SetActive(true);
        }
    }
}
