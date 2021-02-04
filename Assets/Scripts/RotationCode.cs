using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCode : MonoBehaviour
{

    public GameObject orbitTarget;
    private Vector3 angle; 

    public float rotationSpeed = 30;

    public float radius = 10;
    private float age = 0;

    private float randX;
    private float randY;
    private float randZ;

    public static int time = 1;

    private void Start()
    {
        randX = Random.Range(.2f, 4);
        randY = Random.Range(.2f, 4);
        randZ = Random.Range(.2f, 4);
    }

    private void FixedUpdate()
    {
        age += Time.deltaTime * rotationSpeed * time;


        Vector3 offset = new Vector3();
        offset.x = Mathf.Sin(age) * radius;
        offset.z = Mathf.Cos(age) * radius;

        //math
        transform.position = orbitTarget.transform.position + offset;
        transform.Rotate(randX * time, randY * time, randZ * time);
        //transform.rotation = new Quaternion(this.transform.rotation.x + randX, this.transform.rotation.y + randY, this.transform.rotation.z + randZ, this.transform.rotation.w);
    }

}