using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character_State : MonoBehaviour
{
    public bool grounded;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
            Debug.Log("Character now grounded");
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = false;
            Debug.Log("Character no longer grounded");
        }
    }
   
    // Update is called once per frames
    void FixedUpdate()
    {
        Debug.Log(grounded);
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