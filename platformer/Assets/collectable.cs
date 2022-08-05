using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
       if (other.tag == "Player") {
        score.Score++;
        print(score.Score);
        Destroy(gameObject);
       } 
    }
}
