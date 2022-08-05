using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseHealth : MonoBehaviour
{
    public static int HP = 100;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "enemy") {
            HP--;
            Destroy(other.gameObject);
        }
        if (HP <= 0) {
            SceneManager.LoadScene("Game Over");
        }
    }
    private void Update() {
        GameObject.Find("hpCounter").gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "HP: " +  HP;
    }
}
