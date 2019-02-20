using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearOnHard : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        number = PlayerPrefs.GetInt("Difficulty");
        if (number >= 2)//Player.GetComponent<Difficulty>().diff == 2)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<EnemyShoot>().enabled = true;
        }
    }
}
