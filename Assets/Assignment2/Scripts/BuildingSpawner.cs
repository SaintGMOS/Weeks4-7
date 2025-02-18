using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random; // For some reasom I'm not sure why but I'm on your getComponent class and you dont have this line on your code and your not getting an error but I do?

public class BuildingSpawner : MonoBehaviour
{
    // Spawner/Destroy Settings
    public GameObject prefab; // Building Prefab
    public GameObject spawnLocation; // Spawn Location of the Buildings
    private GameObject Building; // Ref to the currently spawned building(Grabs the prefab building having its movement script)
    public float spawnTimeLimit; // Time before spawning another building
    public float timePS; // Time per sec incremented
    public float destoryTime; // The time when the buidling will be destroyed
    public float groupSpawnCount; // # of buidlings group spawn
    private float groupSpawnChecker = 0; // Checks how many buidling ahs been spawned for the if statement

    // Building Settings
    public float minSize;// Min random scale 
    public float maxSize;// Max random scale 
    public float minPos;// Min random  
    public float maxPos;// Max random pos
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        // Increment time 
        timePS += Time.deltaTime;

        // Check if it's time to spawn a new building
        if (timePS >= spawnTimeLimit)
        {
          
            // Random Y position
            float randomPos = Random.Range(minPos, maxPos);
            Vector3 distanceBuilding = new Vector3(randomPos, 0f, 0f);

            // Spawn new building 
            Building = Instantiate(prefab, spawnLocation.transform.position + distanceBuilding, Quaternion.identity);
            Debug.Log("YES");

            // Random SIZE/Scale of the building
            float randomSize = Random.Range(minSize, maxSize);
            Building.transform.localScale = Vector3.one * randomSize;


            // Checks if max amount of buidling in a group spawn
            if (groupSpawnChecker >= groupSpawnCount)
            {
                // reset timePS progress and group spawn count
                timePS = 0;
                groupSpawnChecker = 0;
                Debug.Log("No");

            }
            // Increase the spawnchecker to mach the amount spawned
            groupSpawnChecker++;
      
        }
       // Destroy/despawn buidling
        Destroy(Building, destoryTime);




    }
}

