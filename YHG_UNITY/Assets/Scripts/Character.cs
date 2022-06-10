using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isTalking()
    {
        return false;
    }
    public bool isGrounded()
    {
        return Physics2D.BoxCast(transform.position,new Vector2(transform.localScale.x,transform.localScale.y),0f, Vector2.down, 0.1f, game.ground);        
    }
    public void Jump(float jumpPower, bool jumpCont)
    {
        if(jumpCont)
        {
            rb.AddForce(transform.up*jumpPower, ForceMode2D.Force);
        }else
        {
            rb.AddForce(transform.up*jumpPower, ForceMode2D.Impulse);
        }        
    }
    public void WalkLeft(float walkSpeed)
    {
        rb.AddForce(transform.right*-walkSpeed);
    }
    public void WalkRight(float walkSpeed)
    {
        rb.AddForce(transform.right*walkSpeed);
    }
    public void Talk()
    {
        // game.Dialogue_Manager.StartDialogue();
    }
    private Game game;
    private GameObject gameObj;
    void Start()
    {
        gameObj = GameObject.FindGameObjectWithTag("Game_Manager");
        game = gameObj.GetComponent<Game>();
        rb = GetComponent<Rigidbody2D>();
    }
}
