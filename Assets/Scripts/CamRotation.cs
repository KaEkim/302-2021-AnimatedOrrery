using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation : MonoBehaviour
{
    Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        rot = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (CamRig.rotateDown)
        {
            Quaternion newBoi = new Quaternion(1.0f, rot.y, rot.z, rot.w);
            this.transform.rotation = newBoi;
        }
        else this.transform.rotation = rot;
    }

}