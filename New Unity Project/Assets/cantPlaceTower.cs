using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cantPlaceTower : MonoBehaviour
{
    private void OnMouseOver() {
        placeTower.canPlace = false;
    }
    private void OnMouseExit() {
        placeTower.canPlace = true;
    }
}
