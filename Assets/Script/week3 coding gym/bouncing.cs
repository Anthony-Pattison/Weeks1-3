using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bouncing : MonoBehaviour
{
    [Range(0f, 1f)]
    public float t;
    public float speed = 5f;
    public float jumpspeed = 0.05f;
    bool jump = false;

    public Transform start;
    public Transform end;

    public AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        Vector2 spriteInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (spriteInScreenSpace.x < 0 || spriteInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos;

        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));

        if (Input.GetKeyDown(KeyCode.Space))
        {
             jump = true;
            
        }
        if (jump == true)
        {

            t = t + jumpspeed;
            Debug.Log(t);
            
        }
        if (t >= 1f)
        {
            jump = false;
            t = 0;

        }

    }
    
}
