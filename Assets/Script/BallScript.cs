using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedy = 5;
    public float speedx = 5;
    float dirX = 1;
    float dirY = 1;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Pos = transform.position;

        Pos.y = dirY + speedy;
        Pos.x = dirX + speedx;
        Vector2 ballInScreenSpace = Camera.main.WorldToScreenPoint(Pos);
        if (ballInScreenSpace.y < 0 || ballInScreenSpace.y > Screen.height)
        {
            dirY = dirY * -1;
            speedy = speedy * -1;
        }
        if (ballInScreenSpace.x < 0 || ballInScreenSpace.x > Screen.height)
        {
            dirX = dirX * -1;
            speedx = speedx * -1;
        }

    }
}
