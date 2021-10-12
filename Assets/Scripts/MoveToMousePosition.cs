using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMousePosition : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private Camera mainCamera;
    public float speed;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            var mouseWorld = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            var step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, mouseWorld, step);
        }
    }
}
