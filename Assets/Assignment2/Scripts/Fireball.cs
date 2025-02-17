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

    public float cooldownTime = 2f; // Cooldown duration in seconds
    private float takenShotTime;
    private Timer timer; 

    private Vector3 direction = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        takenShotTime = -cooldownTime; // Iss allowed firing immediately

        // Get Timer component from the same GameObject i think
        timer = GetComponent<Timer>();
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
