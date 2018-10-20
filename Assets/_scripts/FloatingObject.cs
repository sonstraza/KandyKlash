using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour {

    public GameObject floated;
    private Rigidbody rb;
    public float RotationSpeed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, RotationSpeed, 0);
		
	}
}
