using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimal : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawmRangex = 20;
    private float spawmPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnAnimals", startDelay, spawnInterval);
    }

    
    void Update()
    {
        
    }

    void SpawnAnimals()
    {
        int AnimalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawmRangex, spawmRangex), 0, spawmPosZ);

        Instantiate(animalPrefabs[AnimalIndex], spawnPos, animalPrefabs[AnimalIndex].transform.rotation);
    }

}
