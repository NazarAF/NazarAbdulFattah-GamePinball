using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIController : MonoBehaviour {
    public TextMeshProUGUI scoreText;
    public ScoreManager scoreManager;

    private void Update() {
        scoreText.text = scoreManager.score.ToString();
    }
}