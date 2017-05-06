using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBallScript1 : MonoBehaviour {

    private Rigidbody rb;
    public float speed;


    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        //this.gameObject.GetComponent<Rigidbody>().velocity.Equals(Vector3.zero);

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0, 0, moveVertical);

        if(Input.GetKey(KeyCode.W))
            Invoke("HitBall", 1f);
    }

    private void HitBall()
    {
        rb.AddForce(Camera.main.transform.forward * speed);
    } 
}
