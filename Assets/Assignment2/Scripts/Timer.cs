using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Slider slider;
    private float cooldown;
    private float cooldownLeft;


    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        cooldownLeft += Time.deltaTime;
        slider.value = cooldownLeft / cooldown;

    }


    public void CooldownStart(float time)
    {
        cooldown = time;
        cooldownLeft = time;
        slider.value = 1;
    }



}
