using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeTower : MonoBehaviour
{
    public static bool canPlace = true;
    public Vector2 pos;

    void Update()
    {
        if (canPlace && Money.money >=20) {
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos = new(Mathf.Round(pos.x),Mathf.Round(pos.y));
            //print(pos);
            if (Input.GetMouseButtonDown(0)) {
                Instantiate(GameObject.Find("tower"),pos,transform.rotation);
                Money.money-=20;
            }
            
        }
    }
}
