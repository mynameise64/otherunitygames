using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public static int Score = 0;
    private void Update() {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + score.Score;
    }
}
