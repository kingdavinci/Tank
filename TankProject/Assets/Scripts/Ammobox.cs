using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammobox : MonoBehaviour
{
    void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            Destroy(gameObject);
        }
    }
}
