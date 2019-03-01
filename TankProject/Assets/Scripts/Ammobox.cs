using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammobox : MonoBehaviour
{
    public GameObject Player;
    /*  void OnTriggerEnter2D(Collision2D collision)
      {
          if (collision.gameObject.tag == "Spikes")
          {
              Destroy(gameObject);
          }
    */
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Player")
        {
            Player.GetComponent<Ammo>().Missles += 20;
            //this  PlayerPrefs.SetInt("TotalAmmo", Missles + 1);
            Destroy(gameObject);
        }
    }

}
