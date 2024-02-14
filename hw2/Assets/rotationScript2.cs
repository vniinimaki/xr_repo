using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      Transform A = GameObject.FindGameObjectWithTag("LensCamera").transform;
      Transform B = GameObject.FindGameObjectWithTag("MainCamera").transform;
      Vector3 awayDirection = A.position - B.position;
      Quaternion awayRotation= Quaternion.LookRotation(awayDirection);
      A.rotation = awayRotation;
            
    }
}
