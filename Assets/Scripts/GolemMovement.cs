using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemMovement : MonoBehaviour {

    private Rigidbody myBody;
    private float moveForce = 10f;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");

        // why negative? because the golem have rotate (Y) 180 degredes
        myBody.velocity = new Vector3(-h * moveForce, 0f, 0f);
	}
}
