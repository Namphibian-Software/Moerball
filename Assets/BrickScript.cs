using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int brickStrength;

    private void OnTriggerEnter(Collider other)
    {
       
        if (BallScript.collFlag == true)
        {
            //Debug.Log("Brick On Trigger: " + BallScript.collFlag);

          
            BallScript.yspeed = -BallScript.yspeed;
            BallScript.collFlag = false;
            brickStrength--;
            if (this.brickStrength > 0)
            {
                //BallScript.xspeed = -BallScript.xspeed;
                
                if(brickStrength<=1)
                {
                    GetComponent<Renderer>().material.color = Color.yellow;
                    
                }
                else if(brickStrength > 1 && brickStrength <= 2)
                {
                    GetComponent<Renderer>().material.color = Color.cyan;
                   
                }
                else if (brickStrength > 2 && brickStrength <= 3)
                {
                    GetComponent<Renderer>().material.color = Color.blue;
                 
                }
                //BallScript.xspeed = -BallScript.xspeed;
            }
            else
            {
               Destroy(gameObject);
               GameManager.score += 10;

            }

            
        }
        
    }
    
}
