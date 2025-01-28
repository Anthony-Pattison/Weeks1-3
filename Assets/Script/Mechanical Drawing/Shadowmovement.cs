using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shadowmovement : MonoBehaviour
{
    public AnimationCurve curve;
    public Transform start;
    public Transform end;
    [Range (0f,1f)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // using lerp to change the size of the shadow 
        // to make it look like the chicken is flying
        transform.localScale = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        t = t + 0.001f;
        // Reset the curve values back to one so it's continues 
        if (t >= 1)
        {
            t = 0;
        }
    }
}
