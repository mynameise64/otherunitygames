using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int HP;
    float loseHPAnimationCounter;

    public void loseHP(int health) {
        HP-=health;
        loseHPAnimationCounter = 0;
        GetComponent<SpriteRenderer>().color = new Color32(255,165,165,255);
    }
    private void Start() {
        HP = 5*generateWaves.wave + 8*generateWaves.difficulty;
        
    }
    private void Update() {
        if (HP <=0) {
            Money.money+=generateWaves.wave;
            Destroy(gameObject);
        }
        loseHPAnimationCounter+=Time.deltaTime;
        if (loseHPAnimationCounter >= .1) {
            GetComponent<SpriteRenderer>().color = new Color32(85,242,255,255);
        }
    }
}
