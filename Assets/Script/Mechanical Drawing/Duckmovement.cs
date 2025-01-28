using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duckmovement : MonoBehaviour
{

   public AnimationCurve anim;
    [Range (0f,1f)]
    public float t;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        // get keyboard input for wasd
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // if the duck gets to any side of the screen
        // stop it from moving
        if (pos.x < -15 ) {
            pos.x = -14.99f;
        }
        if (pos.x > 5)
        {
            pos.x = 4.99f;
        }
        if (pos.y < -2.7)
        {
            pos.y = -2.69f;
        }
        if (pos.y > 2.5)
        {
            pos.y = 2.49f;
        }
        transform.position = pos;
        
    }
}
