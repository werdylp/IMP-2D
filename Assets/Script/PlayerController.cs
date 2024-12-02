using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 movedir;

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate() //používáme fixedUpdate aby se neovlivnila fyzika
    {
        move();   
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //getAxisRaw se používá, pokud nechceme používat gamepad nebo nechceme mìnit rychlost pøi použití gamepadu. Hodnota je pouze 1 nebo 0 narozdíl od getAxis
        float moveY = Input.GetAxisRaw("Vertical");

        movedir = new Vector2(moveX, moveY).normalized;
    }

    void move()
    {
        rb.velocity = new Vector2(movedir.x * moveSpeed, movedir.y * moveSpeed);
    }
}
