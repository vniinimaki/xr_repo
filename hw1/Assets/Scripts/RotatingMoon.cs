using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingMoon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,20*Time.deltaTime ,0);
    }
}
