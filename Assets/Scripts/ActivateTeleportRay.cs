using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class ActivateTeleportRay : MonoBehaviour
{
    public GameObject rightTeleportation;
    public InputActionProperty rightActivate;

    void Update()
    {
        rightTeleportation.SetActive(rightActivate.action.ReadValue<Vector2>().magnitude>0.1f);
    }
}
