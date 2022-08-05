using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] canAttackEnemies;
    float speed;


    void enemiesInRadius() {
        int b = 0;
        foreach(var enemy in enemies) {
            if (Vector3.Distance(enemy.transform.position,transform.position) < 3) {
                canAttackEnemies[b] = enemy;
                b++;
            }
        }
    }
    void AttackEnemies() {
        foreach(var enemyAtk in canAttackEnemies) {
            speed+=Time.deltaTime;
            if (speed >= .5f) {
                enemyAtk.gameObject.GetComponent<enemyHealth>().loseHP(1);
                speed = 0;
            }
        }
    }

    
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        canAttackEnemies = new GameObject[enemies.Length];
        enemiesInRadius();
        AttackEnemies();
    }
}
