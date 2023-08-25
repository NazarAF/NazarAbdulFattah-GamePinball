using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;
    // public GameObject sfxAudioSource;

	private void Start() {
		PlayBGM();
	}

	public void PlayBGM() {
        this.bgmAudioSource.Play();
    }

    // public void PlaySFX(Vector3 spawnPosition)  {
    //     GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    // }

    public void PlaySFX()  {
        this.sfxAudioSource.Play();
    }
}
