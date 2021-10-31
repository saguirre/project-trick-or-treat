using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullMovement : MonoBehaviour
{
    Vector3 movement;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
    }

    private void FixedUpdate()
    {
        transform.position += movement * Time.fixedDeltaTime * moveSpeed;
    }
}
