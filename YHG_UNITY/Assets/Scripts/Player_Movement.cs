using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    #region Public Vars
    public float Speed;
    public float Drag;
    public float JumpHeight;
    #endregion
    #region Private Vars
    private Rigidbody2D rb;
    private Character_State Character;
    private float speed;
    private float jumpHeight;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Character = GetComponent<Character_State>();
        rb = Character.rb;
        speed = Speed*rb.mass;
        jumpHeight = JumpHeight*rb.mass;
    }
    void Jump()
    {
        if(Character.grounded == true)
        {
            rb.AddForce(transform.up * jumpHeight, ForceMode2D.Impulse);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        #region Player Input
        float walk = Input.GetAxis("Horizontal")*speed;
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

