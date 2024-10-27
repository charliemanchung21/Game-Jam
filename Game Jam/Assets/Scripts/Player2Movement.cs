using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    AudioManager audioManager;
    private float horizontal = 0;
    [SerializeField] private float speed = 8.0f;
    [SerializeField] private float jumpForce = 10.0f;
    private bool isFacingRight = true;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform leftCheck;
    [SerializeField] private Transform rightCheck;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] Rigidbody2D rb;

    public Animator animator;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal = -1;
            if (isFacingRight)
            {
                Flip();
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontal = 1;
            if (!isFacingRight)
            {
                Flip();
            }
        }
        else
        {
            horizontal = 0;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            audioManager.PlaySFX(audioManager.jump);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }

    }

    private bool IsGrounded()
    {
        if (Physics2D.OverlapCircle(groundCheck.position, 0.2f, whatIsGround)) //|| Physics2D.OverlapCircle(leftCheck.position, 0.2f, whatIsGround) || Physics2D.OverlapCircle(rightCheck.position, 0.2f, whatIsGround))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
