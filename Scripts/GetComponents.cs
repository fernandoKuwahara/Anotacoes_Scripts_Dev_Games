using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponents : MonoBehaviour
{
    Rigidbody rig;

    void Start()
    {
        
        rig = GetComponent<Rigidbody>();

        rig.mass = 2;

        Debug.Log(rig.mass);

    }
}
