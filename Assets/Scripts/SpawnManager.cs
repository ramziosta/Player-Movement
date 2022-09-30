using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;
public class SpawnManager : MonoBehaviour
{
        public GameObject[] AnimalPrefabs;
        private float spawnRangeX = 20;
        private float spawnRangeZ = 20;
      
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
     
        if(Input.GetKeyDown(KeyCode.S))
          {
           int animalIndex = Random.Range(0, AnimalPrefabs.Length);
           Vector3 randomPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
           GameObject randomAnimalPrefabs = AnimalPrefabs[animalIndex];
           Instantiate( randomAnimalPrefabs, randomPosition,  randomAnimalPrefabs.transform.rotation);
        }
    }
}
