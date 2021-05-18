using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    // mouse sensitivity
    public float Sensitivity = 100f;
    // player movement speed
    public float Speed = 10f;
    // strength of downward force when not grounded
    public float Gravity = -9.81f;
    // height of jump
    public float JumpHeight = 3f;

    Transform playerBody;
    CharacterController controller;
    Vector3 velocity;

    // Called immediately
    void Awake()
    {
        playerBody = GetComponent<Transform>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMover();
        ApplyGravity();
        ProcessJumping();
    }

    /// <summary>Manage player movement</summary>
    void PlayerMover()
    {
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        playerBody.Rotate(Vector3.up * mouseX);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        // allows player to move based on the direction they're facing 
        // (facing north: left = west, forward = north)
        Vector3 move = -transform.forward * x + transform.right * z;
        controller.Move(move * Speed * Time.deltaTime);
    }

    /// <summary>Apply gravity when player is not grounded</summary>
    void ApplyGravity()
    {
        if (controller.isGrounded && velocity.y < 0)
            velocity.y = 0f;
        
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    /// <summary>Manage player jumping</summary>
    void ProcessJumping()
    {
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity);
    }
}
