using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public void OnJump()
    {
        Debug.Log("Test");
    }
    void OnHowLong(InputValue i)
    {
        string number = i.ToString();
        //int numberInt = int.Parse(number);
        Debug.Log(number);
    }


}
