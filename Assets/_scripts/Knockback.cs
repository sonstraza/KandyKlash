using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Knockback : MonoBehaviour
{

    public CharacterController controller;
    public bool stunned = false;
    float stunTimer;
    public float knockbackDistance = 30;
    public float stunDuration = 3;
    public float knockbackInitialVelocity;
    public float knockbackAcceleration;

    // Use this for initialization
    void Start ()
    {
        controller = this.GetComponent<CharacterController>();

        // Calculate constants for knockback
        knockbackInitialVelocity = 2.0f * knockbackDistance / stunDuration;
        knockbackAcceleration = -knockbackInitialVelocity / stunDuration;
    }
    
	// Update is called once per frame
	void Update () {
        if(stunned)
        {
            KnockbackMethod();
            stunTimer += Time.deltaTime;
            if (stunTimer > stunDuration)
            {
                stunned = false;
            }
        }
        
    }
    void KnockbackMethod()
    {
        controller.Move(Vector3.back * (knockbackInitialVelocity + knockbackAcceleration * stunTimer) * Time.deltaTime);
    }

    /*void OnCollision(Collision collision)
    {
        stunned = true;
        stunTimer += Time.deltaTime;

        if(stunTimer > 2)
        {
            stunned = false;
        }
    }*/
    void StartKnockbackTimer()
    {
        stunTimer = 0;
    }
     void StunPlayer()
    {
        stunned = true;
        StartKnockbackTimer();
    }
}
