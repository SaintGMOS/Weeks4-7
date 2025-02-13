using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
  


        Vector3 movement = new Vector3(moveX, 0, 0f);
        transform.position += movement * speed * Time.deltaTime;



    }
}
