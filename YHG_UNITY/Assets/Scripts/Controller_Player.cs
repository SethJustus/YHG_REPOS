using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Character))]
public class Controller_Player : MonoBehaviour
{
    public float JumpPower;
    public float FloatPower;
    public float AirDrag;
    public float GroundDrag;
    public float AirTime;
    public float WalkSpeed;
    public float AirWalk;
    public bool jumpContinuously;
    private Character character;
    private bool canJump;
    private bool isJumping;
    private float jumpTimer = 0;
    private float Drag;
    private float RealWalkSpeed;
    void Start()
    {
        this.character = GetComponent<Character>();
        JumpPower = JumpPower*character.rb.mass*character.rb.gravityScale;
        FloatPower = FloatPower*character.rb.mass*character.rb.gravityScale;
    }
    void FixedUpdate()
    {
        character.rb.drag = Drag;
        if(character.isGrounded())
        {
            Drag = GroundDrag;
            RealWalkSpeed = WalkSpeed;
        }else
        {
            RealWalkSpeed = WalkSpeed/AirWalk;
            Drag = AirDrag;
        }
        #region Jump Logic
        if(Input.GetAxisRaw("Jump")<=0)
        {
            if(character.isGrounded())
            {
                canJump = true;
                isJumping = false;
                jumpTimer = 0;
            }else
            {
            
                canJump = false;
            }
        }
        if(canJump)
        {
            if(Input.GetAxisRaw("Jump")>0)
            {       
                
                if(jumpContinuously)
                {
                    if(!isJumping)
                    {
                        character.rb.AddForce(transform.up*JumpPower,ForceMode2D.Impulse);
                        isJumping = true;
                    }
                    jumpTimer += 1;
                    Debug.Log("Timer: "+jumpTimer+" Time: "+AirTime);
                    if(jumpTimer>=AirTime)
                    {
                        canJump = false;                    
                    }
                }
                else
                {
                    canJump = false;
                } 
                character.Jump(FloatPower, jumpContinuously);
            }
        }
        #endregion
        float walk = Input.GetAxisRaw("Horizontal");
        if(walk>0)
        {
            character.WalkRight(RealWalkSpeed);
        }else if(walk<0)
        {
            character.WalkLeft(RealWalkSpeed);
        }
    }
}
