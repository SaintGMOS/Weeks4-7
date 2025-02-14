using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuidlingMover : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 left = new Vector3(-1, 0, 0);

        transform.position += left * speed * Time.deltaTime;

    }
}
