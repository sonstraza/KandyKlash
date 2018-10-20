using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour {
    public GameObject playerObject;
    public Vector3 playerPosition;

	// Use this for initialization
	void Start () {
        playerPosition = playerObject.transform.position;
	}
    
	// Update is called once per frame
	void Update () {
		
	}
    void KnockbackMethod()
    {
        playerPosition.x -= 5;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MyGameObjectName")
        {
            KnockbackMethod();
        }
    }
}
