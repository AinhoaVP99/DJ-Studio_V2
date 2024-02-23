using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] musicPrefabs;

    public float spawnRangeX = 5; //limites laterales
    public float startDelay = 2;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomNote", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void SpawnRandomNote()
    {
        Vector3 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), 5);
        int musicIndex = Random.Range(0, musicPrefabs.Length); //genera animalIndex en funcion del numero de prefabs(solo opcion2)
        Instantiate(musicPrefabs[musicIndex], spawnPos, musicPrefabs[musicIndex].transform.rotation); //instancia un animal
    }
}
