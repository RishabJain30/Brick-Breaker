using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Ball") {

            FindAnyObjectByType<GameManager>().Miss();

        }
    }
}
