﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHP : MonoBehaviour {

    public float hp = 70;
    public int lives = 3;
    public Text healthText;
    public Slider healthBar;
    public GameObject prefab;
    public float shootSpeed = 10;
    public GameObject DeathScreen;
    public GameObject prefab2;
    public Text livesText;
    
    // Use this for initialization
    void Start () {
        //PlayerPrefs.SetInt("Lives", lives);
        //lives = PlayerPrefs.GetInt("Lives");
        healthText.GetComponent<Text>().text = "Health: " + hp;
        healthBar.GetComponent<Slider>().value = hp;
        //timerText.GetComponent<Text>().text = "time:" + Mathf.RoundToInt(timer);
        hp = 70;
        //livesText.GetComponent<Text>().text = "Lives: " + lives;
        
    }
    void Update() {
        healthBar.GetComponent<Slider>().value = hp;
        healthText.GetComponent<Text>().text = "Health: " + hp;
        //timer -= Time.deltaTime;
        //if (hp <= 0)
        //{
        //PlayerPrefs.SetInt("Lives", lives - 1);
        //Time.timeScale = 0;
        //DeathScreen.GetComponent<Canvas>().enabled = true;
        //}
        if ( hp <= 0 )
        {
            //PlayerPrefs.SetInt("Lives", lives = 3);
            //Time.timeScale = 1;
            SceneManager.LoadScene("Lose");
        }
    }

        void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            hp -= 2;
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
        if (collision.gameObject.tag == "Soldier")
        {
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Fire")
        {
            hp -= 2;
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
        if (collision.gameObject.tag == "EnemyBullet")
        {
            hp -= 3;
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
     
    }
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            hp -= 2;
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
        if (collision.gameObject.tag == "SoldierBullet")
        {
            hp -= 1;
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
            Destroy(collision.gameObject);
        }
    }
}
