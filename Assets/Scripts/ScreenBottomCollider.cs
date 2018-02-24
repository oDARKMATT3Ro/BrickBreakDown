using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenBottomCollider : MonoBehaviour {

    private LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        SceneManager.LoadScene("_LoseScreen");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
