using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Gyro_Script : MonoBehaviour
{

    Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
        rot=Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.gyro.attitude);

        rot.z= Input.gyro.rotationRateUnbiased.z;
        rot.x= Input.gyro.rotationRateUnbiased.x;
        rot.y=-Input.gyro.rotationRateUnbiased.y;
        transform.Rotate(rot);
        
    }
}
