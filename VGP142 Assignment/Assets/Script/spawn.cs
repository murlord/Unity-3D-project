using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] pickupsPrefabs;

    private float spawnDelay = 5;
    private float nextSpawnTime;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }

    }

    private void Spawn()
    {
        int randItem = Random.Range(0, pickupsPrefabs.Length);
        int randSpawPoint = Random.Range(0, spawnPoints.Length);

        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(pickupsPrefabs[randItem], spawnPoints[randSpawPoint].position, transform.rotation);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }


}
