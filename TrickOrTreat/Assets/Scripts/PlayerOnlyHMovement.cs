using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerOnlyHMovement : MonoBehaviour
{

    public Rigidbody2D rb;

    Vector3 movement;

    private Animator anim;
    public bool isGrounded = true;
    public float moveSpeed = 5f;

    void Start() {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(HeartSystem.canTakeDamage)
        {
            Jump();
            movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            anim.SetFloat("speedX", movement.x);
        }
        else
        {
            movement = new Vector3(0f, 0f, 0f);
            anim.SetFloat("speedX", movement.x);
        }
    }

    private void FixedUpdate()
    {
        transform.position += movement * Time.fixedDeltaTime * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Debug.Log("Jumped");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 4f), ForceMode2D.Impulse);
            SoundManagerScript.PlaySound("jumpPlayer");
        }
    }
}
