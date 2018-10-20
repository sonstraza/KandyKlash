using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Spawn()
    {
        //if (timeLeft == 0){
        //return;
        //}

        // int spawnX = Random.Range (0, spawnPoints.Length);
        // int spawnX = Random.Range (0, spawnPoints.Length);

        //Instantiate();
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //other.candy++;
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}