using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Reference to the Slider UI
    private Slider slider;
    // Cooldown Period
    private float cooldown = 0f;
    // WHen The Colldown Starts
    private float cooldownStart = 0f;
    // Cooldown Tracking 
    private bool isCooldownOn = false;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Slider
        slider = GetComponent<Slider>();
        // Slider = 0 or like empty
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Is Cooldown Currently Active?
        if (isCooldownOn)
        {
            // Calcs how much time has passed since the start of the Cooldown
            float incrementTime = Time.time - cooldownStart;

            // Checks if cooldown is still in progress/ if the increment time is still going 
            if (incrementTime < cooldown)
            {
                // Fills slider depending on the time
                slider.value = incrementTime / cooldown; 
            }
            else
            {
                // MAKES SURE the slider is full when cooldown time runs out
                slider.value = 1;
                // Stop tracking cooldown
                isCooldownOn = false; 
            }
        }
    }

    // Cooldown start method
    public void CooldownStart(float time)
    {
        // Set the duration od the cooldown
        cooldown = time;
        // Makes the current time the start of the cooldown
        cooldownStart = Time.time; //  NOTE: I'm not sure if we are allowed to use this but I'm aware that this tells yopu how many sec passed since the game started
        // But in my code Time.time records when the cooldown starts, keeps track of the time passed, and supports updating the slider 
        // Start cooldown tracking
        isCooldownOn = true;
        // Reset to empty
        slider.value = 0;
        
    }



}
