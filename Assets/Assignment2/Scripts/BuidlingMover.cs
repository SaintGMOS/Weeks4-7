using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuidlingMover : MonoBehaviour
{
    public GameObject prefab;
    public static float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 loc = transform.position;

        loc.x += -speed * Time.deltaTime;

        transform.position = loc;
    }


    public void Speed(float s)
    {
        speed = s;
       

    }



}
