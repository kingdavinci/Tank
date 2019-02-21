using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearHard : MonoBehaviour
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
        if (number >= 3)//Player.GetComponent<Difficulty>().diff == 2)
        {
           gameObject.SetActive(false);
          //  GetComponent<SpriteRenderer>().enabled = false;
          //  GetComponent<BoxCollider2D>().enabled = false;
           // GetComponent<EnemyShoot>().enabled = true;
        }
    }
}
