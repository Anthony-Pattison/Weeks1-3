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
        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        pos.x += speed;
        transform.position = pos;
        if (squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }
        
    }
}
