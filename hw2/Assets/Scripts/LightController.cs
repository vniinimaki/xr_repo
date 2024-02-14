using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightController : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
    light = GetComponent<Light>();
    action.action.Enable();
    action.action.performed += ctx => 
    {
        light.color = Color.red;
    };
    }

    // Update is called once per frame
    void Update()
    {

    }
}
