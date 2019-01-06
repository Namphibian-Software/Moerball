using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWallScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BallScript.xspeed = 16.0f;
        BallScript.collFlag = true;
       // Debug.Log("Left wall");
    }
}
