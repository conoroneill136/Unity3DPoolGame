using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueScript : MonoBehaviour {

    public GameObject whiteBall;


    public Rigidbody rb;
    void Start()
    {
        rb = whiteBall.GetComponent<Rigidbody>();
        rb.velocity.Equals(Vector3.zero);

    }

    void FixedUpdate()
    {


    }

    void Update()
    {
        if (rb.velocity.x > 0.1 && rb.velocity.x < - 0.1 && rb.velocity.z > 0.1 && rb.velocity.z < -0.1)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }

}
