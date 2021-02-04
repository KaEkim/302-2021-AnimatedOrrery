using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditTime : MonoBehaviour
{
    public void NormalSpeed()
    {
        RotationCode.time = 1;
    }

    public void FastSpeed()
    {
        if (RotationCode.time > 1)
        {
            RotationCode.time += 1;
        }
        else RotationCode.time = 2;
    }

    public void stopSpeed()
    {
        RotationCode.time = 0;
    }

    public void RewindSpeed()
    {
        if (RotationCode.time < 0)
        {
            RotationCode.time -= 1;
        }
        else RotationCode.time = -1;
    }

    public void freeCam()
    {
        CamRig.isFree = true;
    }

    public void unFreeCam()
    {
        CamRig.isFree = false;
    }

}
