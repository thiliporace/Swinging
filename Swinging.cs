using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swinging : MonoBehaviour
{
    [Header("Input")] 
    public KeyCode swingKey = KeyCode.Mouse1;

    private void Update()
    {
        if(Input.GetKeyDown(swingKey)) StartSwing();
        if(Input.GetKeyUp(swingKey)) StopSwing();
    }

    private void StartSwing()
    {
        
    }

    private void StopSwing()
    {
        
    }
}
