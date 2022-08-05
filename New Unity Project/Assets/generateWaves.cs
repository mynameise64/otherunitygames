using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateWaves : MonoBehaviour
{
    public static int difficulty = 1;
    public static int wave = 0;

    private void Update() {
        if (GameObject.FindGameObjectsWithTag("enemy").Length <= 1) {
            wave++;
            //print(wave);
            if (wave%3 == 0) {
                difficulty++;
            }
        }
        if (GameObject.FindGameObjectsWithTag("enemy").Length <= 1) {
            GameObject.Find("enemy").gameObject.GetComponent<followPath>().speed = difficulty*10;
            for(int i = 0; i < Mathf.Min(wave*3,300); i++) {
                Instantiate(GameObject.Find("enemy"),new(-9.71f+(-3*(i+1)),0,0),transform.rotation);
                GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
                for(int n = 0; n < enemies.Length; n++) {
                    enemies[n].GetComponent<followPath>().setTarget(new Vector3(transform.position.x+0.2f,transform.position.y,0),0);
                }
                
            }
            GameObject.Find("enemy").gameObject.GetComponent<followPath>().speed = 0;
        }
    }
}
