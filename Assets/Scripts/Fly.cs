using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fly : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody2D rbFlpy;
    // Start is called before the first frame update
    void Start()
    {
        rbFlpy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            rbFlpy.velocity = Vector2.up * speed;
        }
    }
    private void  FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rbFlpy.velocity.y*rotationSpeed);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.instance.GameOver();
    }
}
