using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float width = 6f;
    private SpriteRenderer spriteRender;
    private Vector2 startSize;
    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        startSize = new Vector2(spriteRender.size.x, spriteRender.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        spriteRender.size = new Vector2(spriteRender.size.x * speed * Time.deltaTime, spriteRender.size.y);
        if (spriteRender.size.x > width)
        {
            spriteRender.size = startSize;
        }
    }
}
