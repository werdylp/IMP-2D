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

    private void FixedUpdate() //pou��v�me fixedUpdate aby se neovlivnila fyzika
    {
        move();   
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //getAxisRaw se pou��v�, pokud nechceme pou��vat gamepad nebo nechceme m�nit rychlost p�i pou�it� gamepadu. Hodnota je pouze 1 nebo 0 narozd�l od getAxis
        float moveY = Input.GetAxisRaw("Vertical");

        movedir = new Vector2(moveX, moveY).normalized;
    }

    void move()
    {
        rb.velocity = new Vector2(movedir.x * moveSpeed, movedir.y * moveSpeed);
    }
}
