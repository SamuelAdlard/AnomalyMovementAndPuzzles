using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch : MonoBehaviour
{
    public bool IsOn = false;
    public GameObject Light;
    public int FuelTime = 300;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            IsOn = !IsOn;
        }
        if (IsOn)
        {
            Light.SetActive(true);
        }
        else
        {
            Light.SetActive(false);
        }

    }
    private void Start()
    {
        InvokeRepeating("Timer", 0f, 0.1f);
    }

    private void Timer()
    {
        if (IsOn && FuelTime > 0)
        {
            FuelTime -= 1;
        }
        else if (!IsOn && FuelTime < 300)
        {
            FuelTime += 1;
        }
        
        if(FuelTime == 0)
        {
            IsOn = false;
        }
        
    }
}
