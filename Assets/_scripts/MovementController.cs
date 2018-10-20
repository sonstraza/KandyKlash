using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public CharacterController controller;
    public float movementSpeed = 10;

    // Use this for initialization
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update ()
    {
        // By default: not moving any direction
        Vector3 inputDirection = new Vector3(0, 0, 0);

        // Add inputs to direction
        if (Input.GetKey(KeyCode.W))
        {
            inputDirection += Vector3.forward; 
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputDirection += Vector3.back;

        }
        if (Input.GetKey(KeyCode.A))
        {
            inputDirection += Vector3.left;

        }
        if (Input.GetKey(KeyCode.D))
        {
            inputDirection += Vector3.right;

        }

        // Take unit vector of movement direction
        inputDirection.Normalize();

        // Move by inputDirection
        controller.Move(inputDirection * Time.deltaTime * movementSpeed);
    }
}
