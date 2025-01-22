using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    bool bullet = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bullet == null)
        {
            spawn();
        }
        if (bullet == null)
        {
            spawn();
        }
    }
    void spawn()
    {


    }
    void fire()
    {
       // bullets.hasBeenFired = true;

    }
}
