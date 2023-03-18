using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Head;
    public GameObject Cam;
    public GameObject SpaceShip;


    float CurrRot;
    float PrevRot;
    float DeltRot;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Head.transform.Translate(Cam.transform.forward * Time.deltaTime * 2f);
        tilt();
    }

    void tilt()
    {
        CurrRot = Cam.transform.eulerAngles.y;
        DeltRot = CurrRot - PrevRot;
        PrevRot = CurrRot;

        if (DeltRot > 0)
        {
            SpaceShip.transform.localRotation =
                Quaternion.Lerp(
                    SpaceShip.transform.localRotation,
                    Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, -45),
                    Time.deltaTime
                    );
        }
        else if (DeltRot < 0)
        {
            SpaceShip.transform.localRotation =
                Quaternion.Lerp(
                    SpaceShip.transform.localRotation,
                    Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 45),
                    Time.deltaTime
                    );
        }
        else
        {
            SpaceShip.transform.localRotation =
                Quaternion.Lerp(
                    SpaceShip.transform.localRotation,
                    Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 0),
                    Time.deltaTime * 3f
                    );
        }
    }
}
