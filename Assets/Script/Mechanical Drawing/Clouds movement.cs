using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cloudsmovement : MonoBehaviour
{
    public float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cloudPos = transform.position;
       // using a public speed value so
       // it can change the speed for the diffrent clouds
        cloudPos.x += Speed * Time.deltaTime;

        Vector2 cloudsInScreenSpace = Camera.main.WorldToScreenPoint(cloudPos);
        if( cloudsInScreenSpace.x > Screen.width)
        {
            // takes the position in game space then subtracks it by itself *2
            // no matter the size of the screen the clouds will respawn in the right side of the screen
            cloudPos.x = cloudPos.x - cloudPos.x*2;       
        }
        
        transform.position = cloudPos;
    }
}
