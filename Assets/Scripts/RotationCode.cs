using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCode : MonoBehaviour
{

    public GameObject orbitTarget;
    private Vector3 angle; 

    public int rotationSpeed = 30;

    public float radius = 10;
    private float age = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        age += Time.deltaTime * rotationSpeed;

        Vector3 offset = new Vector3();
        offset.x = Mathf.Sin(age) * radius;
        offset.z = Mathf.Cos(age) * radius;

        


        //math

        transform.position = orbitTarget.transform.position + offset;
    }

}