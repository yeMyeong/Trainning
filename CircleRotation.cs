using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    float rotSpeed = 0.0f; // 회전 속도

    void Update()
    {
        if(Input.GetMouseButton(0)) // 마우스를 좌클릭하면
        {
            rotSpeed = 10; // 회전 속도가 올라감
        }

        transform.Rotate(0, 0, rotSpeed); // Rotate(x, y, z) 를 사용하여 돌아감

        rotSpeed *= 0.99f; // 점점 속도가 느려짐
    }
}
