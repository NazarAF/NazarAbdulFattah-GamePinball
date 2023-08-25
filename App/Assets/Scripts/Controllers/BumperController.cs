using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour {
    public float score;
    public float multiplier;
    public Collider ball;
    public Color color;

    private new Renderer renderer;
    private Animator animator;

    public AudioManager audioManager;
    public ScoreManager scoreManager;

    void Start() {
        (this.renderer = GetComponent<Renderer>()).material.color = color;
        this.animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider == this.ball) this.Bump(collision);
	}

    private void Bump(Collision collision) {
        Rigidbody rigid;
        this.animator.SetTrigger("onHit");
        (rigid = this.ball.GetComponent<Rigidbody>()).velocity *= this.multiplier;
        // audioManager.PlaySFX(collision.transform.position);
        audioManager.PlaySFX();
        scoreManager.AddScore(this.score);
    }
}
