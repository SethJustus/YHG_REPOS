using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character_State : MonoBehaviour
{
    [SerializeField] private LayerMask layerGround;
    public bool grounded;
    public bool talking;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if(collision.gameObject.tag == "Ground")
    //     {
    //         grounded = true;
    //         Debug.Log("Character now grounded");
    //     }
    // }
    // void OnCollisionExit2D(Collision2D collision)
    // {
    //     if(collision.gameObject.tag == "Ground")
    //     {
    //         grounded = false;
    //         Debug.Log("Character no longer grounded");
    //     }
    // }
   
    // Update is called once per frames
    void FixedUpdate()
    {
        Debug.Log(grounded);
        
    }
    public bool IsGrounded()
    {
        Debug.Log("Is the player grounded?");
        return Physics2D.BoxCast(transform.position, transform.localScale,0f,Vector2.down, 0.5f,layerGround);
    }
    // void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if(collision.gameObject.tag == "Ground")
    //     { 
    //         grounded = true;
    //     }
    // }
    // void OnTriggerExit2D(Collider2D collision)
    // {
    //     if(collision.gameObject.tag == "Ground")
    //     {
    //         grounded = false;
    //     }
    // }
}
