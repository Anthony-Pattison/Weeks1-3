using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public List<GameObject> spawnedThings;

    // Start is called before the first frame update
    void Start()
    {
        spawnedThings = new List<GameObject> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // this creates a prefab based on the position of the mouse
            GameObject newThing = Instantiate(prefab, mouse, Quaternion.identity);
            
            newThing.transform.localScale = Vector3.one * Random.Range(0.75f, 1.5f);

            spawnedThings.Add(newThing);
            
            movementcode myScript = newThing.GetComponent<movementcode>();
            myScript.thingsThatSpawnedMe = this;
            if(myScript != null)
            {
                myScript.speed = Random.Range(.01f, .05f);
            }
            //Instantiate(prefab, transform);
            //Destroy(newThing, 5);  
        }
    }
}
