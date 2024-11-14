using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cameraMove : MonoBehaviour
{
    public InputActionReference gyro;


    public void Start()
    {
        gyro.action.Enable();
        InputSystem.EnableDevice(UnityEngine.InputSystem.Gyroscope.current);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(gyro.action.ReadValue<Vector3>());
    }


}
