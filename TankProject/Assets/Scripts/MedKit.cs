using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 3.0f;
    public float paceSpeed = 2.0f;
    public float health = 10;
    public GameObject Player;
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacement = transform.position - startPosition;
        float distanceFromStart = displacement.magnitude;
        if (distanceFromStart >= paceDistance)
        {
            // flip directions
            paceDirection = -paceDirection;
        }
        paceDirection.Normalize();
        GetComponent<Rigidbody2D>().velocity = paceDirection * paceSpeed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Player.GetComponent<PlayerHP>().hp += 5;
            Destroy(gameObject);
        }
    }
}
