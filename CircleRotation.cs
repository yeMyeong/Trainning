using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    float rotSpeed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            rotSpeed = 10;
        }

        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= 0.99f;
    }
}
