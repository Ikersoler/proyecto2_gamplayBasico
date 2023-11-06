using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ramdom = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject[] animalPrefabArray;

    private int animalIndex;
    private float spawnRangex = 15f;
    private float spawnPosZ = 20f;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spaunInterval = 1.5f;



    private void Start()
    {
        

        InvokeRepeating("SpawnRandomAnimal",
            startDelay, spaunInterval);



    }

    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabArray.Length);
        Instantiate(animalPrefabArray[animalIndex],
         new Vector3(x: 0, y: 0, z: spawnPosZ),
         Quaternion.Euler(x: 0, y: 180, z: 0));
    }

    private Vector3() 
    {
        float randomX = Random.Range(-spawnRangex, spawnRangex);
        return new Vector3( randomX, y:0, spawnPosZ);
    }








}
