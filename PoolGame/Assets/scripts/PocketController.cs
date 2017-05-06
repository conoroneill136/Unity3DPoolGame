using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketController : MonoBehaviour {

    public GameObject whiteball;
    Vector3 startPosition;
    void Start()
    {
        startPosition = whiteball.transform.position;
    }

    void FixedUpdate()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Spot"))
        {
            other.gameObject.SetActive(false);
            ScoreManager.setScore("Spot");
        }
        if (other.gameObject.CompareTag("Stripe"))
        {
            other.gameObject.SetActive(false);
            ScoreManager.setScore("Stripe");
        }
        if (other.gameObject.CompareTag("Black"))
        {
            other.gameObject.SetActive(false);
            ScoreManager.setScore("Black");
        }
        if (other.gameObject.CompareTag("White"))
        {
            whiteball.transform.position = startPosition;
            whiteball.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;

        }
    }
}

