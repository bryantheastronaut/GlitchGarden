using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    [SerializeField] int loadingDelay = 3;

    int currentSceneIdx;
    // Start is called before the first frame update
    void Start() {
        currentSceneIdx = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIdx == 0) {
            StartCoroutine(DelayedNavigation());
        }
    }

    IEnumerator DelayedNavigation() {
        yield return new WaitForSeconds(loadingDelay);
        LoadNextScene();
    }

    public void LoadNextScene() {
        currentSceneIdx++;
        SceneManager.LoadScene(currentSceneIdx);
    }

    public void LoadLoseScene() {
        SceneManager.LoadScene("GameOverScreen");
    }
}
