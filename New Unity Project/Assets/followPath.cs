using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  

public class followPath: MonoBehaviour {  
    public Vector3[] target;
    public float speed = 0;  
    public int current = 1;  
    // Use this for initialization    
    public Vector3 getTarget(int x) {
        return target[x];
    }
    public void setTarget(Vector3 pos,int x) {
        target[x] = pos;
    }
    void Start() {}  
    // Update is called once per frame    
    void Update() {  
        if (Vector3.Distance(transform.position, target[current]) > 0.1f) {  
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current], speed * Time.deltaTime);  
            GetComponent<Rigidbody2D>().MovePosition(pos);  
        } else current = (current + 1) % target.Length;  
    }  
} 