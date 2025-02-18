using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    // Fireball prefab
    public GameObject prefab;
    // Spwn location of FB
    public GameObject fBSpawn;
    // CURRENT spawned FB
    private GameObject fB;
    // Timer used for the Cooldown UI
    public Timer timer;
    // Fireball Speed
    public float speed;
    // Time when its gonna be destroyed
    public float destroyTime;

    // Cooldown between each fb
    public float cooldownTime = 2f; 
    // When the fb can be fired next
    private float nextFireTime = 0f;
    // Makes sure you can't shoot on cooldown
    private bool isOnCooldown = false;

    // The direction the fireball moves (rightward by default)
    private Vector3 direction = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        //timer = GetComponent<Timer>();  // Get Timer component from the same GameObject i think (This thing was causing problems for some reason. It kept unassigning timer when played. Keeping it for notes
    }

    // Update is called once per frame
    void Update()
    {
        // Check if fireball is on cooldown
        if (isOnCooldown)
        {
            // If the cooldown time has passed, allow firing again
            if (Time.time >= nextFireTime)
            {
                // Cooldown finished, allow shooting again
                isOnCooldown = false; 
            }
        }
        // If a fireball is currently active, move it
        if (fB != null)
        {
            fB.transform.position += direction * speed * Time.deltaTime;
        }

    }

    // Method for the Inspector button
    public void Shoot()
    {
        // Allow shooting if not on cooldown
        if (!isOnCooldown) 
        {
            // Spawn FB
            fB = Instantiate(prefab, fBSpawn.transform.position, Quaternion.identity);

            // Despawn FB
            Destroy(fB, destroyTime);

            // Set the next fire time based on cooldown duration
            nextFireTime = Time.time + cooldownTime; 

            // Start cooldown
            isOnCooldown = true;

            // If a Timer component is assigned, start the cooldown UI whcih connects to TIMER
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
