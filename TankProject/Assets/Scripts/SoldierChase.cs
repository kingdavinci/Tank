using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierChase : MonoBehaviour
{
    public GameObject player;
    public float chaseSpeed = 1.0f;
    public float chaseTriggerDistance = 4.0f;
    Vector3 startPosition;
    bool home = true;
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 7.0f;
    public float paceSpeed = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startPosition = transform.position;
        paceDirection.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        // vector from the enemy position to the player position
        Vector3 chaseDirection = playerPosition - transform.position;
        // if the player is 4 away and the trigger distance is 5 then start chasing
        if (chaseDirection.magnitude < chaseTriggerDistance)
        {
            
            //Chase because the player is close to the enemy
            home = false;
            if(chaseDirection.magnitude < 2.0f)
            {
                return;
            }
          //  Debug.Log("continue");
            chaseDirection.Normalize();
            //Debug.Log(chaseDirection);
            GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
            // runs if the player is not close enough to the enemy
            /*if (chaseTriggerDistance <= 0.5f)
            {
                home = true;
                Vector3 homeDirection = startPosition - transform.position;
                homeDirection.Normalize();
                GetComponent<Rigidbody2D>().velocity = homeDirection * paceSpeed;
            }*/
        }
        else if (home == false)
        {
            //see how far way we are from home
            Vector3 homeDirection = startPosition - transform.position;
            // if close to home, reset our position to home and reset our velocity
            if (homeDirection.magnitude < 0.3f)
            {
                home = true;
                transform.position = startPosition;
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
            else
            {
                //go home
                homeDirection.Normalize();
                GetComponent<Rigidbody2D>().velocity = homeDirection * paceSpeed;
            }

        }
        else
        {
            Vector3 displacement = transform.position - startPosition;
            float distanceFromStart = displacement.magnitude;
            if (distanceFromStart >= paceDistance)
            {
                // flip directions
                displacement.Normalize();
                paceDirection = -displacement;
            }
            paceDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = paceDirection * paceSpeed;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           chaseSpeed = 0.0f;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        chaseSpeed = 1.0f;
    }
}
