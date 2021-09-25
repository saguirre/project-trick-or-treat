using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float RunSpeed = 40f;
    private float _horizontalMove = 0f;

    // Update is called once per frame
    void Update()
    {
        _horizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;
    }

    void FixedUpdate()
    {
        // Move character
        controller.Move(_horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
