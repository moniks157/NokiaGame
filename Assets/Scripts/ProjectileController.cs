using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {
    Rigidbody rb;
    GameObject target;
    public float speed = 5f;

	void Start () {
        rb = GetComponent<Rigidbody>();
    }

	void Update () {
        rb.velocity = (transform.forward) * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CharacterController.HEALTH--;
        }
        Destroy(gameObject);
    }
}
