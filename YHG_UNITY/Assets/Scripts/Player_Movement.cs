using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float Speed;
    public float Drag;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float walk = Input.GetAxis("Horizontal")*Speed;
        float jump = Input.GetAxis("Jump");
        Vector3 horizontalMovement = new Vector3(walk,0,0);
        rb.AddForce(horizontalMovement, ForceMode2D.Force);
        rb.drag = Drag;
        //transform.Translate(horizontalMovement);
    }
}
