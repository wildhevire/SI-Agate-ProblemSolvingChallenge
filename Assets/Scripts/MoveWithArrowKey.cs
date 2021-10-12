using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithArrowKey : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    
    private Vector2 direction;
    public float speed;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        direction = new Vector2(horizontal, vertical);
    }

    void FixedUpdate()
    {
        rigidBody2D.velocity = direction.normalized * speed;
    }
}
