using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random; // For some reasom I'm not sure why but I'm on your getComponent class and you dont have this line on your code and your not getting an error but I do?

public class BuildingSpawner : MonoBehaviour
{
    // Spawner/Destroy Settings
    public GameObject prefab;
    public GameObject spawnLocation;
    private GameObject Building;
    public float spawnTimeLimit;
    public float timePS;
    public float destoryTime;
    public float groupSpawnCount;
    private float groupSpawnChecker = 0;

    // Building Settings
 
    public float minSize;        // Min random scale 
    public float maxSize;           // Max random scale 
    public float minPos;        // Min random  
    public float maxPos;           // Max random pos
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        timePS += Time.deltaTime;

        if (timePS >= spawnTimeLimit)
        {
          

            float randomPos = Random.Range(minPos, maxPos);
            Vector3 distanceBuilding = new Vector3(randomPos, 0f, 0f);

     
            Building = Instantiate(prefab, spawnLocation.transform.position + distanceBuilding, Quaternion.identity);
            Debug.Log("YES");

            float randomSize = Random.Range(minSize, maxSize);
            Building.transform.localScale = Vector3.one * randomSize;



            if (groupSpawnChecker >= groupSpawnCount)
            {
                timePS = 0;
                groupSpawnChecker = 0;
                Debug.Log("No");

            }
            groupSpawnChecker++;
      
        }
       
        Destroy(Building, destoryTime);




    }
}

