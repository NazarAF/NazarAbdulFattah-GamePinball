using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    public float score;
        
    private void Start() { this.ResetScore(); }

    public void AddScore(float addition) { score += addition; }

    public void ResetScore() { this.score = 0; }
}
