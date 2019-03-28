using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alexController : MonoBehaviour {
    bool moving;
    bool attacking;
    float movementSpeed;
    float movementSpeedMulti;
    public Rigidbody rigid;
    //public Animator animPlayer;
    public GameObject playerObject;

    public Transform playerTransform;

    public float speed;
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
        playerTransform = GetComponent<GameObject>().transform;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigid.AddForce(movement * speed);
    }
    // Update is called once per frame
    void Update () {
		
	}

    void PlayerController()
    {
        Vector3 inputDirection = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.W))
        {
            inputDirection += transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(inputDirection.normalized), 0.15f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(inputDirection.normalized), 0.15f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            inputDirection -= transform.forward;
        }

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        if (movement != Vector3.zero)
        {
            moving = true;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.15f);
        }
        if (movement == Vector3.zero)
        {
            //moving = false;
        }

        if (moving == true && attacking == true)
        {
            //moving = false;
        }

        transform.Translate(movement * (movementSpeed * movementSpeedMulti) * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
        }
    }
}
