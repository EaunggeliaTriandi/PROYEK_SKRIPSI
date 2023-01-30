using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D PlayerRb;
    public Animator PlayerAnimator;

    public bool movementToggler = false;

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        if (movementToggler == true)
        {

            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");


            PlayerAnimator.SetFloat("PlayerX", movement.x);
            PlayerAnimator.SetFloat("PlayerY", movement.y);
            PlayerAnimator.SetFloat("Speed", movement.sqrMagnitude);

            if (Input.GetAxisRaw("Horizontal") == 1 ||
                Input.GetAxisRaw("Horizontal") == -1 ||
                Input.GetAxisRaw("Vertical") == 1 ||
                Input.GetAxisRaw("Vertical") == -1)
            {
                PlayerAnimator.SetFloat("PlayerLastX", Input.GetAxisRaw("Horizontal"));
                PlayerAnimator.SetFloat("PlayerLastY", Input.GetAxisRaw("Vertical"));
            }
        }
    }
    private void FixedUpdate()
    {
        PlayerRb.MovePosition(PlayerRb.position + movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
