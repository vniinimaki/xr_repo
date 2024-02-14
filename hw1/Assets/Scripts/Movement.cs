
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public InputActionReference action;
    private bool isOriginLocation = true;
    void Start()
    {
        action.action.Enable();
        action.action.performed += ctx =>
        {
            if (isOriginLocation)
            {
                transform.position = new Vector3(0, 4999, 0);
                isOriginLocation = false;
            }
            else
            {
                transform.position = new Vector3(-1,2,-3);
                isOriginLocation = true;
            }
        };
    }
}
    


