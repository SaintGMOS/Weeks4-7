using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuidlingMover : MonoBehaviour
{
    public GameObject prefab; // Reference to the building prefab (not used in movement logic)
    public static float speed; // Speed at which the building moves
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the GameObject
        Vector3 loc = transform.position;

        // Move the object left by decreasing its x
        loc.x += -speed * Time.deltaTime;
       
        // Apply the new position to the GameObject
        transform.position = loc;
    }

    // Set the movement speed of the building
    public void Speed(float s)
    {
        // Assigns the given speed value to the static variable(To all speed)
        speed = s;
       

    }



}
