using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject prefab;
    public GameObject fBSpawn ;
    private GameObject fB;
    public float speed;
    public float destroyTime;
    private Vector3 direction = new Vector3(1, 0, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
        
            Destroy(fB, destroyTime);

        }

        if (fB != null)
        {
            fB.transform.position += direction * speed * Time.deltaTime;
        }

    }


    public void Shoot()
    {

        fB = Instantiate(prefab, fBSpawn.transform.position, Quaternion.identity);
        Destroy(fB, destroyTime);


    }

}
