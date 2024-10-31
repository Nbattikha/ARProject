using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class force : MonoBehaviour
{
    public GameObject muzzle;
    private float thrust = 5f;
    public Rigidbody rb;

    void Start()
    {
        muzzle = GameObject.Find("Muzzle");
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(muzzle.transform.forward * thrust, ForceMode.Impulse);

    }

    public void Update()
    {      
        
    }



}
