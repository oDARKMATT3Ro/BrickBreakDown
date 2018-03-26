using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static void LoadScene(string sceneName)
    // public void LoadLevel(string name)
    {
        Debug.Log("Loading Level: " + sceneName);
        // Application.LoadLevel(name);
        SceneManager.LoadScene(sceneName);
    }

    public void QuitRequest() {
        Debug.Log("Quit application requested.");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public static void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BrickDestroyed() {
        if (Brick.brickCount <= 0) {
            LoadNextLevel();

        }
    }
}
