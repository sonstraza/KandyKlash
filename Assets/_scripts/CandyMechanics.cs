using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CandyMechanics : MonoBehaviour
{
    playerStats playerStatScript;
    public GameObject playerObject;
    public GameObject[] spriteCandyList;

    //public Clock clock;

    GameObject candyToSpawn;
    public float spawnTimer = 5f;

    bool candySpawned;
    
    // Use this for initialization
    void Start()
    {
        playerObject = this.GetComponent<GameObject>();
        playerStatScript = this.GetComponent<playerStats>();

        candySpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0 && candySpawned == false)
        {
            candySpawned = true;
            //candyToSpawn = spriteCandyList[Random.Range(0, 5)];
            Instantiate(spriteCandyList[Random.Range(0, 5)]);
        }
    }

    void Spawn()
    {
        Instantiate(candyToSpawn);
    }

    void OnTrigger(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //implement a candy count to the player
            Debug.Log("Collect candy");
            candySpawned = false;
            spawnTimer = 0;
            playerStatScript.candyAmount++;
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}