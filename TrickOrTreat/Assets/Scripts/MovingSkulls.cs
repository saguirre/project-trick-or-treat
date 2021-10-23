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
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
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
}
