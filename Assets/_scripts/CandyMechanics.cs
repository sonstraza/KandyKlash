using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CandyMechanics : MonoBehaviour
{
    public GameObject Player;
    //public Clock clock;
    public GameObject candyToSpawn;
    public float spawnTimer = 5f;

    void Spawn()
    {
        Instantiate(candyToSpawn);
        //Clock clock =
        //if (Clock.timeLeft == 0){
        //return;
        //}
        //long spawn = Random.Range (0, spawnPoints.Length);
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= 1f;
        if (spawnTimer <= 0)
            Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //implement a candy count to the player
            //other.candyCount++;
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}