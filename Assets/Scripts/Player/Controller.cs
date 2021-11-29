using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller
{
    private Rigidbody2D rigidbody;
    private Camera camera;
    private Vector2 movement;
    private Vector2 mousePos;
    private float moveSpeed;

    public Controller(Rigidbody2D rigidbody, float moveSpeed, Camera camera)
    {
        this.rigidbody = rigidbody;
        this.moveSpeed = moveSpeed;
        this.camera = camera;
    }

    public void setMovement()
    {
        this.movement.x = Input.GetAxisRaw("Horizontal");
        this.movement.y = Input.GetAxisRaw("Vertical");

        this.mousePos = this.camera.ScreenToWorldPoint(Input.mousePosition);
    }

    public void move()
    {
        this.rigidbody.MovePosition(this.rigidbody.position + this.movement * this.moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = this.mousePos - this.rigidbody.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        this.rigidbody.rotation = angle;
    }
}
