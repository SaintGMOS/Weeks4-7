using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2 : MonoBehaviour
{
    public SpriteRenderer sr;
    public float speed;
    public float tracker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tracker = -speed * Time.deltaTime;


        transform.Rotate(0, 0, tracker);
        Vector3 rot = transform.eulerAngles; // Tracks the Z/Degree

        if (rot.z % 30 < 1 && rot.z % 30 >= 0)
        {
            sr.enabled = true;
            Debug.Log("Work");
        }
        else
        {
            sr.enabled = false;

        }
        // WHATS WRONG WITH THIS WERE TRACKING THE BIRD NOT THE HOUR HAND
    }
}
