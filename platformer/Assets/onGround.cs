using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onGround : MonoBehaviour
{
    [SerializeField] public static bool isonGround;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "ground") {
            isonGround = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "ground") {
            isonGround = false;
        }
    }
}
