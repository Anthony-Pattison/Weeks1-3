using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateArms : MonoBehaviour
{
    public float rotateSpeed;
    public bool minhand;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 rot = transform.eulerAngles(0, rotateSpeed);
        if (!minhand) {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);

        }
        if (minhand)
        {
            transform.Rotate(0, 0, rotateSpeed*12 * Time.deltaTime);

        }
    }
}