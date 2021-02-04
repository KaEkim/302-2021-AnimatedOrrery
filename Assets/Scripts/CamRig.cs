using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRig : MonoBehaviour
{
    public static bool rotateDown = false;
    public static GameObject target;
    public static bool isFree = false;
    // Start is called before the first frame update
    private void Start()
    {
        CamRig.target = GameObject.Find("OriginalCamPos");
    }

    private void FixedUpdate()
    {
        if (isFree)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, 1);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, -1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-1, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(1, 0, 0);
            }

        }
        else
        {
            Vector3 absoluteDistance = new Vector3(this.transform.position.x - target.transform.position.x, this.transform.position.y - target.transform.position.y, this.transform.position.z - target.transform.position.z);
            this.transform.position -= absoluteDistance / 5;
        }


    }

}