using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSkulls : MonoBehaviour
{
    public float moveSpeed = 5f;
    Vector3 movement;

    void Start()
    {
        new WaitForSeconds(Random.Range(0.2f, 1));
    }

    void Update()
    {
        movement = new Vector3(-5f * Time.fixedDeltaTime, 0f, 0f);
    }

    private void FixedUpdate()
    {
        transform.position += movement * Time.fixedDeltaTime * moveSpeed;
        transform.rotation = Quaternion.identity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SkullMovementEndPosition"))
        {
            transform.SetPositionAndRotation(new Vector2(2f, Random.Range(-0.175f, 0.378f)), Quaternion.identity);
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            Physics2D.IgnoreCollision(collision.otherCollider, collision.collider);
        }
    }
}
