using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScript : MonoBehaviour
{
    // Start is called before the first frame update
 
    void Start()
    {
        
    }
    private float anchorZ = 0.0f;
    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 location = GameObject.FindGameObjectWithTag("MainCamera").transform.eulerAngles;
        Vector3 thisRotation = new Vector3(location.x, location.y, anchorZ);
        thisRotation.x = Mathf.Clamp(thisRotation.x, 0f, 360f);
        thisRotation.y = Mathf.Clamp(thisRotation.y, 0f, 360f);
        //thisRotation.z = Mathf.Clamp(thisRotation.z, 0f, 360f);
        transform.eulerAngles = thisRotation;
        */
        Transform location = GameObject.FindGameObjectWithTag("LookingPoint").transform;
        transform.LookAt(location, transform.up);
    }
}
