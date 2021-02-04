using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lines : MonoBehaviour
{
    public int segments;
    public GameObject orbitTarget;
    public float Radius = 10;
    LineRenderer line;



    // Start is called before the first frame update
    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();

        line.SetVertexCount(segments + 1);
        line.useWorldSpace = false;
        CreatePoints();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreatePoints()
    {
        float x = 0;
        float y = 0;
        float z = 0;

        float angle = 20f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * Radius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * Radius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }

}
