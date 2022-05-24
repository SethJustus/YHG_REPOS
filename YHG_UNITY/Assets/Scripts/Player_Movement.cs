using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float Speed;
    public float Drag;
    public float JumpHeight;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Jump()
    {
        bool jumped = false;
        if(jumped == false)
        {
            rb.AddForce(transform.up * JumpHeight, ForceMode2D.Impulse);
            jumped = true;
        }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        #region Player Input
        float walk = Input.GetAxis("Horizontal")*Speed;
        float jump = Input.GetAxis("Jump");
        if(Input.GetAxis("Jump") == 1)
        {
            Jump();
        }
        #endregion

        #region Move the player

        //Makes a new Vector3 by which to move the player by.
        Vector3 horizontalMovement = new Vector3(walk,0,0);
        //Adds force to the player
        rb.AddForce(horizontalMovement, ForceMode2D.Force);
        //Adds drag to the player
        rb.drag = Drag;
        #endregion
    }
}

