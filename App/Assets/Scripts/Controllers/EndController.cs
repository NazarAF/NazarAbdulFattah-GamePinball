using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour {
    public Collider ball;
    public Collider spawnPoint;
    public GameObject gate;

    public ScoreManager scoreManager;

    private void OnCollisionStay(Collision collision) {
        if (collision.collider == this.ball) Respawn();
    }

    private void Respawn() {
        this.ball.transform.position = this.spawnPoint.transform.position;
        this.gate.GetComponent<GateController>().isOpen = false;
        this.gate.GetComponent<GateController>().setGate();
        scoreManager.ResetScore();
        SceneManager.LoadScene("Game Over");
    }
}
