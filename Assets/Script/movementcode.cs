using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movementcode : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        transform.position = pos;
        if (pos.x >= 7.7)
        {
            speed = speed * -1;
        }
        if (pos.x <= -7.7)
        {
            speed = speed * -1;
        }
    }
}
