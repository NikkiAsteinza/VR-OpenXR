using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateDistanceGrab : MonoBehaviour
{
    public GameObject rightDistanceGrab;
    public InputActionProperty rightActivate;
    
    public GameObject leftDistanceGrab;
    public InputActionProperty leftActivate;

    void Update()
    {
        rightDistanceGrab.SetActive(rightActivate.action.ReadValue<float>()>0.01f);
        leftDistanceGrab.SetActive(leftActivate.action.ReadValue<float>()>0.01f);
    }
}
