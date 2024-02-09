using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private PlayerControls control;
    private Vector2 move;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        control = new PlayerControls();

        // Bind the Move action
        control.Movement.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        control.Movement.Move.canceled += ctx => move = Vector2.zero;
    }

    private void OnEnable()
    {
        control.Enable();
    }

    private void OnDisable()
    {
        control.Disable();
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(move.x, move.y) * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }
   
}
