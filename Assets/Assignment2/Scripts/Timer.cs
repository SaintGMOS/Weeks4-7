using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Slider slider;
    private float cooldown = 0f;
    private float cooldownStart = 0f;
    private bool isCooldownOn = false;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (isCooldownOn)
        {
            float incrementTime = Time.time - cooldownStart;

            if (incrementTime < cooldown)
            {
                slider.value = incrementTime / cooldown; // Gradually increase slider
            }
            else
            {
                slider.value = 1; // Fill the slider when cooldown is done
                isCooldownOn = false; // Stop tracking cooldown
            }
        }
    }


    public void CooldownStart(float time)
    {
        cooldown = time;
        cooldownStart = Time.time; // Store the exact time the cooldown starts
        isCooldownOn = true; // Start cooldown tracking
        slider.value = 0; // Start from empty
    }



}
