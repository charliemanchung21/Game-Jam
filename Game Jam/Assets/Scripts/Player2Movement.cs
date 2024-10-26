using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public CharacterController controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalMove = -runSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalMove = runSpeed;
        }
        else
        {
            horizontalMove = 0;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
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