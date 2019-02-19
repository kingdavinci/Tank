using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour {

    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    private bool grounded = false;
    public float spinSpeed = 1;
    // treat as horizontal (moveDir)
    public float moveDir = 0;
    public float moveVert = 0;
    public GameObject Player;
    public Vector3 PlayerPosition;
    public int Direction = 1;
    Vector3 shootDir;
    public float shootSpeed = 0;
    public GameObject BulletPrefab;

    // Use this for initialization
    void Start() {
        shootDir = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(Input.GetKeyDown("A"))
        {
            moveDir = -1;
            Direction = 4;
            Debug.Log("Left");
        }
        if (Input.GetKeyDown("D"))
        {
            moveDir = 1;
            Direction = 3;
            Debug.Log("Right");
        }
        if (Input.GetKeyDown("W"))
        {
            moveVert = 1;
            Direction = 1;
            Debug.Log("Up");
        }
        if (Input.GetKeyDown("S"))
        {
            moveVert = -1;
            Direction = 2;
            Debug.Log("Down");
        }

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
        Direction = 1;
        Debug.Log("Up");
    }
    public void MoveDown()
    {
        moveVert = -1;
        Direction = 2;
        Debug.Log("Down");
    }
    public void Stop2()
    {
        moveVert = 0;
    }
    public void MoveRight()
    {
        moveDir = 1;
        Direction = 3;
        Debug.Log("Right");
        // transform.Rotate(0,0,-spinSpeed, Space.World);
    }
    public void MoveLeft()
    {
        moveDir = -1;
        Direction = 4;
        Debug.Log("Left");
    }
    public void Stop()
    {
        moveDir = 0;
    }
    public void Jump()
    {
        if (grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
        }
    }
    public void Shoot()
    { //Up
        if (Direction == 1)
        {
            shootDir = new Vector3(0, .5f, 0);//transform.position;
            shootDir.Normalize();
            Vector3 offset = shootDir;
            shootDir = shootDir * shootSpeed;
            GameObject bullet = (GameObject)Instantiate(BulletPrefab,
                transform.position + offset, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir;
            Destroy(bullet, 2.0f);
            //Down
        } else if (Direction == 2)
        {
            shootDir = new Vector3(0, -.5f, 0);
            shootDir.Normalize();
            Vector3 offset = shootDir;
            shootDir = shootDir * shootSpeed;
            GameObject bullet = (GameObject)Instantiate(BulletPrefab,
                transform.position + offset, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir;
            Destroy(bullet, 2.0f);
            //Right
        } else if (Direction == 3)
        {
            shootDir = new Vector3(.5f, 0, 0);
            shootDir.Normalize();
            Vector3 offset = shootDir;
            shootDir = shootDir * shootSpeed;
            GameObject bullet = (GameObject)Instantiate(BulletPrefab,
                transform.position + offset, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir;
            Destroy(bullet, 2.0f);
            //Left
        } else if (Direction == 4)
        {
            shootDir = new Vector3(-.5f, 0, 0);
            shootDir.Normalize();
            Vector3 offset = shootDir;
            shootDir = shootDir * shootSpeed;
            GameObject bullet = (GameObject)Instantiate(BulletPrefab,
                transform.position + offset, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir;
            Destroy(bullet, 2.0f);
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
