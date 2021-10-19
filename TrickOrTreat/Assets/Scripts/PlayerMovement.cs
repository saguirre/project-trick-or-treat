using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;

    Vector2 movement;

    private Animator anim;

    public float moveSpeed = 5f;

    void Start() {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("speedX", movement.x);
        anim.SetFloat("speedY", movement.y);
    }

    void FixedUpdate()
    {
        // Move character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
