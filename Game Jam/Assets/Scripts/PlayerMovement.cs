using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;    
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetKey(KeyCode.A))
        {
            horizontalMove = -runSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontalMove = runSpeed;
        }
        else
        {
            horizontalMove = 0;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

}
