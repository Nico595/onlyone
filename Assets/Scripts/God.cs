using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    public float TopBoundY = 2.25f;
    public float BotBoundY = -2.25f;


  void Start () {
    rb = GetComponent<Rigidbody2D> ();
  }

  void Update () {

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        // If the ball position is outside the boundaries
        var pos = transform.position;
        if (pos.y > TopBoundY)
        {
            pos.y = TopBoundY;
        }
        else if (pos.y < BotBoundY)
        {
            pos.y = BotBoundY;
        }
        transform.position = pos;

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }


}