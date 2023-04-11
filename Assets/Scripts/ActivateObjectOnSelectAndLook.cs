using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateObjectOnSelectAndLook : MonoBehaviour
{
    public Camera camera;
    public LayerMask targetLayer;
    public GameObject objectToActivate;
    public InputActionProperty rightActivate;

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(camera.transform.forward, camera.transform.forward * 2);
        bool activate = false;
        if (Physics.Raycast(ray, out hit, targetLayer))
        {
            activate = rightActivate.action.ReadValue<float>()>0.01f;
        }
        objectToActivate.SetActive(activate);
    }
}
