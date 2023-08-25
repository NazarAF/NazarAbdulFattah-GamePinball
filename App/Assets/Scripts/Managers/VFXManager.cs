using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
	public GameObject vfxSource;
    public Collider ball;

	public void PlayVFX(Vector3 spawnPosition) {
		GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == this.ball) this.PlayVFX(collision.transform.position);
    }
}
