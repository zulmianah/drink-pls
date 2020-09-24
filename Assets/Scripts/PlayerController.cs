using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed, jumpForce, horizontalMove=0f;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true, isGrounded;

    public Transform groundCheck;

    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
    }

    public void Reward()
    {

    }

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight==true && moveInput>0)
        {
            Flip();
        }
        else if(facingRight == false && moveInput < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        this.transform.localScale = Scaler;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey == false)
        {
            animator.SetBool("idle", true);
            animator.SetBool("jump", false);
            animator.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.A) == true || Input.GetKeyDown(KeyCode.D) == true)
        {
            animator.SetBool("walk", true);
            animator.SetBool("jump", false);
            animator.SetBool("idle", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            animator.SetBool("jump", true);
            animator.SetBool("walk", false);
            animator.SetBool("idle", false);
        }
        if (isGrounded==true)
        {
            extraJumps = extraJumpsValue;
        }
        if (Input.GetKeyDown(KeyCode.Space)&&extraJumps>0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0&&isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
