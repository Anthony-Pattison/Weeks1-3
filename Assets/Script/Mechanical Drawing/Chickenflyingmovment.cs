using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chickenflyingmovment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this makes the the chicken fallow the mouse in screen space
        Vector2 mousePoition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // gives the movement to the position of the chicken
        transform.position = mousePoition;
    }
}
