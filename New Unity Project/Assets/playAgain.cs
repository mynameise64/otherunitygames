using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour
{
    public static void reset() {
        Money.money = 0;
        loseHealth.HP = 100;
        generateWaves.wave = 0;
        generateWaves.difficulty = 1;
        SceneManager.LoadScene("game");
    }
}
