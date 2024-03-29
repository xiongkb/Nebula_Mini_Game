/* 
    ==================================
    DIG3878 Spring 2023
    Kang Xiong
    Assignment: Midterm
    This file name: PlayerMovement.cs
    Note: the following code is based on two youtube tutorials for 3rd person movement and camera following using cinemamachine
    ==================================
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    
    // movement
    [Header("Movement")]
    public float moveSpeed = 5f;
    public float groundDrag;

    [Header("Jump Settings")]
    public float jumpForce;
    public float jumpCD; //cool down
    public float airMultiplier; // air resistance when in the air
    bool readyToJump = true; //if ready to jump

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask theGround;
    bool grounded = false;

    public Transform orientation;

    Rigidbody rb;
    Vector3 moveDirection;
    float horizontal;
    float vertical;

    void Start() {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    
    void Update()
    {
        
        //ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f +0.2f, theGround);

        if (grounded) {
            Invoke(nameof(ResetJump), jumpCD);
        }
        
        PlayerInputs();
        SpeedControl();

        //handle drag
        // if(grounded){
        //     rb.drag = groundDrag;
        // } else {
        //     rb.drag = 0;
        // }
        Jump();

    }

    void FixedUpdate() {
        MovePlayer();
    }

    void PlayerInputs(){
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer(){
        //calculate movement directon
        moveDirection = orientation.forward * vertical + orientation.right * horizontal;
        
        // on the ground
        if(grounded){
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        } else if(!grounded){
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }
        
    }

    void SpeedControl() {
        //limiting movement velocity
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        // if movment velocity is greater than move speed, readjust so it doesn't go over
        if(flatVelocity.magnitude > moveSpeed){
            Vector3 limitedVelocity = flatVelocity.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVelocity.x, rb.velocity.y, limitedVelocity.z);
        }
    }

    void Jump(){

        if(Input.GetKey(jumpKey) && readyToJump){
            rb.AddRelativeForce(Vector3.up * jumpForce * 100f * Time.deltaTime);
            StartCoroutine(LoseJump());
        }

    }

    void ResetJump(){
        //reinitialize jump
        readyToJump = true;
        
    }

    //start falling after 2 seconds in the air
    IEnumerator LoseJump(){
        yield return new WaitForSeconds(2);
        readyToJump = false;

    }
}
