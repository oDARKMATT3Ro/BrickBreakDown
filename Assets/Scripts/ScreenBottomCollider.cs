using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenBottomCollider : MonoBehaviour {

    public LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        SceneManager.LoadScene("_WinScreen");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
