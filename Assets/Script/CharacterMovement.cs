using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Ground Check Settings")]

    [Tooltip("Add the empty gameobject that is groundcheck")]
    public Transform groundCheck;

    [Tooltip("Define the radius for ground check")]
    public float groundCheckRadius;

    [Tooltip("Add layer mask to ground")]
    public LayerMask whatIsGround;
    private bool onGround;

    [Header("The player")]
    [Tooltip("The players rigidbody2D")]
    public Rigidbody2D rb;

    [Header("Add audio for jumping")]
    public AudioClip jump;
    private AudioSource Audio;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(5, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

    }

    public void Jump()
    {
        if(onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 8);
            Audio.PlayOneShot(jump);
        }

    }
}
