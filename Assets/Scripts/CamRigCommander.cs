using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamRigCommander : MonoBehaviour
{

    // Start is called before the first frame update
    public void GoBackhome()
    {
        CamRig.target = GameObject.Find("OriginalCamPos");
        CamRig.rotateDown = false;
    }
    
    public void LookAtPlanet1()
    {
        CamRig.target = GameObject.Find("Planet1");
        CamRig.rotateDown = true;
    }
    public void LookAtPlanet2()
    {
        CamRig.target = GameObject.Find("Planet2");
        CamRig.rotateDown = true;
    }
    public void LookAtPlanet3()
    {
        CamRig.target = GameObject.Find("Planet3");
        CamRig.rotateDown = true;
    }
    public void LookAtPlanet4()
    {
        CamRig.target = GameObject.Find("Planet4");
        CamRig.rotateDown = true;
    }
    public void LookAtPlanet5()
    {
        CamRig.target = GameObject.Find("Planet5");
        CamRig.rotateDown = true;
    }
}
