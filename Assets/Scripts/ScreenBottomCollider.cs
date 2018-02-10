using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBottomCollider : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
