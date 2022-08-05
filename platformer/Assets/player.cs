using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    GameObject cam;

    private void Start() {
        cam = GameObject.Find("Main Camera");
    }
    
//     float distToGround;
//     // Start is called before the first frame update
//     void Start()
//     {
//         distToGround = GetComponent<Collider2D>().bounds.extents.y;
//     }
     
     

//  bool IsGrounded() {
//    return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
//  }
 
    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody2D>().AddForce(Vector3.up*5);

        if ((Input.GetKeyDown("w") || Input.GetKeyDown("space")) && onGround.isonGround) {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up*500);
        }
        if (Input.GetKey("d")) {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right*2);
            GameObject.Find("Circle").gameObject.transform.localPosition = new(0.3398111f,0.4304131f);
            GameObject.Find("Circle (1)").gameObject.transform.localPosition = new(0.3578f,0.4304131f);
        }
        if (Input.GetKey("a")) {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left*2);
            GameObject.Find("Circle").gameObject.transform.localPosition = new(-0.3398111f,0.4304131f);
            GameObject.Find("Circle (1)").gameObject.transform.localPosition = new(-0.3578f,0.4304131f);
        } //
        if (transform.position.y > 5) {
            cam.transform.position = new(cam.transform.position.x,5,-10);
        }
    }
    
}
