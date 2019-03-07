using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossHP : MonoBehaviour
{
    public float hp = 30;
    public GameObject healthBar;
    public GameObject healthText;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.GetComponent<Slider>().value = hp;
        healthText.GetComponent<Text>().text = "BossHP: " + hp;
    }

    // Update is called once per frame
    void Update()
    {
     //   healthBar.GetComponent<Slider>().value = hp;
       // healthText.GetComponent<Text>().text = "BossHP: " + hp;
        if (hp <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Win");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hp -= 1;
            healthText.GetComponent<Text>().text = "BossHP: " + hp;
            healthBar.GetComponent<Slider>().value = hp;
        }
    }
}
