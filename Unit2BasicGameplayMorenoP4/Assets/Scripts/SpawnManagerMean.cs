using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerMean : MonoBehaviour
{
    // this is for the array
    public GameObject[] spawnAnimals;

    // this is for the top spawn
    private float spawnRangeX = 12;
    private float spawnRangeZ = 20;

    // this is for the spawn time interval
    private float startDelay = 2;
    private float spawnInterval = 2;

    // this is for the side spawns
    private float spawnSideX = 20;
    private float spawnSideZ = 15;


    // Start is called before the first frame update
    void Start()
    {
        // this is the code for the spawning animal at time interval first is the (method, start time, then the interval)
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("sideSpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        // this is to randomize the anime spawn in the array
        int animalIndex = Random.Range(0, spawnAnimals.Length);

        // the limit of the position of the spawning of animals
        Vector3 spawnXPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        // this is the code to copy or clone the object within the game
        Instantiate(spawnAnimals[animalIndex], spawnXPosition, spawnAnimals[animalIndex].transform.rotation);

    }

    void sideSpawnRandomAnimal()
    {
        // this is to randomize the anime spawn in the array
        int animalIndex = Random.Range(0, spawnAnimals.Length);

        // so that it is facing right
        Vector3 rotationRight = new Vector3(0, 90, 0);

        // facing left
        Vector3 rotationLeft = new Vector3(0, 270, 0);

        // the limit of the position on the left of the spawning of animals
        Vector3 spawnleftPosition = new Vector3(-spawnSideX, 0, Random.Range(0, spawnSideZ));

        // the limit of the position on the right of the spawning of animals
        Vector3 spawnrightPosition = new Vector3(spawnSideX, 0, Random.Range(0, spawnSideZ));

        // this is the code to copy or clone the object within the game
        Instantiate(spawnAnimals[animalIndex], spawnrightPosition, Quaternion.Euler(rotationLeft));
        Instantiate(spawnAnimals[animalIndex], spawnleftPosition, Quaternion.Euler(rotationRight));
    }
}
