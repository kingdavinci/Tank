using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHP : MonoBehaviour {

    public float hp = 40;
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
        hp = 40;
        //livesText.GetComponent<Text>().text = "Lives: " + lives;
        
    }
    void Update() {
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
            hp -= 1;
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
        if (collision.gameObject.tag == "Fire")
        {
            hp -= 1;
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
        if (collision.gameObject.tag == "MedKit")
        {
            hp += 1;
            Destroy(collision.gameObject);
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
        if (collision.gameObject.tag == "EnemyBullet")
        {
            hp -= 1;
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
    }
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            hp -= 1;
            healthText.GetComponent<Text>().text = "Health: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
    }
}
