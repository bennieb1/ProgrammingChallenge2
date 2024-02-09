using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Movements : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 7.0f;
    public Animator animator;
   
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.2f;

    private Rigidbody2D rb;

    private bool isAttacking = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        

        MovePlayer();
        if (Input.GetButtonDown("Jump") && !isAttacking)
        {
            Jump();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }

        // Update the IsJumping animation parameter
        animator.GetBool("IsJumping");
    }

    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        // Set animation parameters
        animator.SetBool("IsWalking", Mathf.Abs(moveHorizontal) > 0);
        if( moveHorizontal == 0){ 
        
            animator.SetBool("IsIdle", true);

        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        animator.SetBool("IsJumping", true);
 
    }

    void Attack()
    {
        isAttacking = true;
        animator.SetBool("IsAttacking", true);
        // Reset 'isAttacking' in an animation event at the end of the attack animation
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Lava") || other.gameObject.CompareTag("DeathZone"))
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("IsJumping", false);
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
