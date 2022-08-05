using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBlock : MonoBehaviour
{
    float time;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Player") {
            time = Time.time;
        }
         void Update() {
            if (time > 0) {
                if (Time.time-time >= 2) {
                    GetComponent<Rigidbody2D>().gravityScale=1;
                }
            }
        }
    }
}
