using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static int money = 20;
    
    private void Update() {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Money: $" + money;
    }
}
