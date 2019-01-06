using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTopScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BallScript.yspeed = -BallScript.yspeed;
        BallScript.collFlag = true;
    }
}

