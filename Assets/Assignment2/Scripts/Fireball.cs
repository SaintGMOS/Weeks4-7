using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject prefab;
    public GameObject fBSpawn;
    private GameObject fB;
    public Timer timer;
    public float speed;
    public float destroyTime;

    public float cooldownTime = 2f; // Cooldown duration
    private float nextFireTime = 0f;
    private bool isOnCooldown = false; // Prevents shooting while on cooldon
   

    private Vector3 direction = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        //timer = GetComponent<Timer>();  // Get Timer component from the same GameObject i think (This thing was causing problems for some reason. It kept unassigning timer when played.
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnCooldown)
        {
            if (Time.time >= nextFireTime)
            {
                isOnCooldown = false; // Cooldown finished, allow shooting again
            }
        }
        if (fB != null)
        {
            fB.transform.position += direction * speed * Time.deltaTime;
        }

    }


    public void Shoot()
    {

        if (!isOnCooldown) // Only shoot if cooldown is finished
        {
            fB = Instantiate(prefab, fBSpawn.transform.position, Quaternion.identity);
            Destroy(fB, destroyTime);

            nextFireTime = Time.time + cooldownTime; // Set next allowed fire time
            isOnCooldown = true; // Start cooldown

            if (timer != null)
            {
                Debug.Log("Cooldown started");
                timer.CooldownStart(cooldownTime); // Start UI cooldown timer
            }
            else
            {
                Debug.Log("No timer");

            }
        }

    }
}
