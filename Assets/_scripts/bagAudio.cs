using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagAudio : MonoBehaviour {

    public AudioSource medHitSource;
    public AudioSource bigHitSource;
    public AudioSource bagMissSource;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //Change for when bag is < 50% full
        if (Input.GetKeyDown(KeyCode.O))
            medHitSource.Play();

        //Change for when bag is > 50% full
        if (Input.GetKeyDown(KeyCode.I))
            bigHitSource.Play();

        //Change for when the player doesn't hit anything
        if (Input.GetKeyDown(KeyCode.P))
            bagMissSource.Play();
	}
}
