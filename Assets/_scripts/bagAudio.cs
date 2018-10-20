using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagAudio : MonoBehaviour {

   
    public AudioSource medHitSource;
    public AudioSource bigHitSource;

	// Use this for initialization
	void Start () {
       // medHitSource.clip medHit; 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            medHitSource.Play();

        if (Input.GetMouseButtonDown(0))
            bigHitSource.Play();
	}
}
