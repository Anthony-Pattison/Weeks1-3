using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movementcode : MonoBehaviour
{
    public float speed = -0.01f;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public Spawner thingsThatSpawnedMe;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 5);
        //spriteRenderer.color = Random.ColorHSV();
        if (sprites.Length == 0)
        {

        }
        else
        {
            // picks a random sprite from a list of sprites it also accounts the array list starting at zero
            spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];
            spriteRenderer.sortingOrder = -1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        
        if (squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos;
    }
}
