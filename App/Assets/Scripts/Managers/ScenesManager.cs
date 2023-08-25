using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {
    void Start() {
        // SceneManager.LoadScene("Main Menu");
        SceneManager.UnloadScene("Pinball");
        SceneManager.UnloadScene("Game Over");
    }
}
