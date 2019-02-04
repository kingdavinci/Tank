using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour {

    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    private bool grounded = false;
    public float spinSpeed = 1;
    // treat as horizontal (moveDir)
    private float moveDir = 0;
    private float moveVert = 0;
    public GameObject Player;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * moveDir;
        GetComponent<Rigidbody2D>().velocity = velocity;
        Vector3 velocity2 = GetComponent<Rigidbody2D>().velocity;
        velocity2.y = moveSpeed * moveVert;
        GetComponent<Rigidbody2D>().velocity = velocity2;
    }
    public void MoveUp()
    {
        moveVert = 1;
    }
    public void MoveDown()
    {
        moveVert = -1;
    }
    public void Stop2()
    {
        moveVert = 0;
    }
    public void MoveRight()
    {
        moveDir = 1;
        transform.Rotate(0,0,-spinSpeed, Space.World);
    }
    public void MoveLeft()
    {
        moveDir = -1;
    }
    public void Stop()
    {
        moveDir = 0;
    }
    public void Jump()
    {
        if(grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer ==8)
        {
            grounded = false;
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }
}
