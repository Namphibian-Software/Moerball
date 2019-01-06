using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBrickScript : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 15; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.name = "Brick";
                cube.transform.position = new Vector3(x * 2f - 14f, y - 1f, 0);
                cube.transform.localScale = new Vector3(1.7f, 0.7f, 1f);
                //Collider m_ObjectCollider = cube.GetComponent<Collider>();

                //
                //m_ObjectCollider = GetComponent<Collider>();
                //Here the GameObject's Collider is not a trigger
                //m_ObjectCollider.isTrigger = true;
                //m_ObjectCollider.enabled = true;
                //cube.tag="Brick";
                //cube.AddComponent<BrickScript>();
                BrickScript script = cube.AddComponent<BrickScript>() as BrickScript;
                cube.GetComponent<Collider>().isTrigger = true;
                //Output whether the Collider is a trigger type Collider or not
                //Debug.Log("Trigger On : " + cube.GetComponent<Collider>().isTrigger);
                if (y < 2)
                {
                    cube.GetComponent<Renderer>().material.color = Color.yellow;
                    script.brickStrength = 1;
                }
                else if (y < 4)
                {
                    cube.GetComponent<Renderer>().material.color = Color.cyan;
                    script.brickStrength = 2;
                }
                else if (y < 6)
                {
                    cube.GetComponent<Renderer>().material.color = Color.blue;
                    script.brickStrength = 3;
                }
                else
                {
                    cube.GetComponent<Renderer>().material.color = Color.red;
                    script.brickStrength = 4;
                }
                //cube.GetComponent<Renderer>().material.color = new Color(0.2f + y * 0.08f, 0.3f, 1.0f);
                
                //cube.renderer.material.color = new Color(0.2f + y * 0.08f, 0.3f, 1.0f);
            }
        }
    }

    
}
