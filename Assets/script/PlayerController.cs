using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isGrounded;
    private Rigidbody2D rb;
    public float jumpForce = 5f;
    private Animator anim;
    public AudioClip JumpSound;
    public AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platforms"))
        {
            this.transform.parent = collision.transform;
            isGrounded = true;

        }

        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platforms"))
        {
            isGrounded = true;
            anim.SetBool("jump", false);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platforms"))
        {
            this.transform.parent = null;
            isGrounded = false;
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void Move()
    {
        float horiz = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horiz * moveSpeed, rb.velocity.y);
        anim.SetBool("walk", horiz !=0);
        if (horiz > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (horiz < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        
    }

    private void Jump()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
            
        {
            audioSource.PlayOneShot(JumpSound);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetBool("jump", true);
        }
    }
}
    
