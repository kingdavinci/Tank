﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoShootOnWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            GetComponent<EnemyShoot>().enabled = false;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<EnemyShoot>().enabled = true;
    }
}
