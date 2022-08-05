using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lava : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "lava") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
