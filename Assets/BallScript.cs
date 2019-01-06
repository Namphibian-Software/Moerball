using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public AudioClip beepSound  ;
    public AudioClip brickSound;
    public AudioClip brickBump;
    public AudioSource audioSource;
    public static float launchtimer;
    public static float xspeed;
    public static float yspeed;
    public static Boolean collFlag;
    // Start is called before the first frame update
    void Start()
    {
        launchtimer = 2.0f;
        xspeed = 16.0f;
        yspeed = 16.0f;
        collFlag = true;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(transform.position.x, transform.position.y);
        launchtimer -= Time.deltaTime;
        if (launchtimer <= 0.0)
        {
           transform.Translate(new Vector3(xspeed, yspeed, 0) * Time.deltaTime);
            launchtimer = 0.0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.name != "Brick")
        { 
            GetComponent<AudioSource>().PlayOneShot(beepSound);

        }
        else if((other.name == "Brick"))
        {
            if (other.GetComponent<BrickScript>().brickStrength > 0)
            {
                GetComponent<AudioSource>().PlayOneShot(brickBump);
            }
            else
            {
                GetComponent<AudioSource>().PlayOneShot(brickSound);
            }
        }
        
    }
}
