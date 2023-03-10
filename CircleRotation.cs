using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    float rotSpeed = 0.0f; // ȸ�� �ӵ�

    void Update()
    {
        if(Input.GetMouseButton(0)) // ���콺�� ��Ŭ���ϸ�
        {
            rotSpeed = 10; // ȸ�� �ӵ��� �ö�
        }

        transform.Rotate(0, 0, rotSpeed); // Rotate(x, y, z) �� ����Ͽ� ���ư�

        rotSpeed *= 0.99f; // ���� �ӵ��� ������
    }
}
