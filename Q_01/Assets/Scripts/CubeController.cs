using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 SetPoint { get; private set; }

    public void SetPosition(float x, float y, float z)
    {
        SetPoint = new Vector3(x, y, z);
        
        transform.position = SetPoint;
    }
}
