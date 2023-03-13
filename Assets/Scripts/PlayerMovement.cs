using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    

    [Header("Movement")]
    public float moveSpeed = 5f;

    public Transform orientation;

    Rigidbody rb;
    Vector3 moveDirection; 

    void Start() {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // private void FixedUpdate() {
    //     MovePlayer();
    // }
    void Update()
    {
        MovePlayer();
       // MoveInputs();
    }

    // void MoveInputs(){
    //     float horizontal = Input.GetAxisRaw("Horizontal");
    //     float vertical = Input.GetAxisRaw("Vertical");
    // }

    void MovePlayer(){
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //calculate movement directon
        moveDirection = orientation.forward* vertical + orientation.right * horizontal;

        rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Force);

        
    }
}
