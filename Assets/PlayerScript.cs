using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Cursor.lockState = UnityEngine.CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Translate(-20 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(20 * Time.deltaTime, 0, 0);
        }
       
        float h = 30.0f * Time.deltaTime * Input.GetAxis("Mouse X");
        transform.Translate(h, 0, 0);
        if (transform.position.x <= -12.5)
        {
            transform.position = new Vector3(-12.5f, -15f, 0f);
        }
        if(transform.position.x >=12.5)
        {
            transform.position = new Vector3(12.5f, -15f, 0f);
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        BallScript.yspeed = -BallScript.yspeed;
        
        if (other.GetComponent<Collider>().gameObject.transform.position.x > gameObject.transform.position.x)
        {
            BallScript.xspeed = Mathf.Abs(BallScript.xspeed);
        }
        else
        {
            BallScript.xspeed = -Mathf.Abs(BallScript.xspeed);
        }
        BallScript.collFlag = true;
    }
}
