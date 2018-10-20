using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CandyMechanics : MonoBehaviour
{
    playerStats playerStatScript;
    public GameObject playerObject;
    //public Clock clock;
    public GameObject candyToSpawn;
    public float spawnTimer = 5f;
    
    // Use this for initialization
    void Start()
    {
        playerObject = this.GetComponent<GameObject>();
        playerStatScript = this.GetComponent<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
            Spawn();
    }
    void Spawn()
    {
        Instantiate(candyToSpawn);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //implement a candy count to the player

            playerStatScript.candyAmount++;
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}