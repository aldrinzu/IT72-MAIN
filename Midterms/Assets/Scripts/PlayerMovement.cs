﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = -5.0f;
    private float gravityValue = -9.81f;

    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }


    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        controller.Move(move * Time.deltaTime * playerSpeed);
        //
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");
    }
}
