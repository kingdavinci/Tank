using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BossTrigger : MonoBehaviour
{
    public float timer = 90;
   // public GameObject BossHP;
   // public GameObject BossHPText;
    bool boss = false;
    public GameObject Boss;
    public Text time;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Help");
    }

    // Update is called once per frame
    void Update()
    {
        if(boss == true)
        {
            timer -= Time.deltaTime;
            Boss.GetComponent<BossHP>().healthBar.SetActive(true);
            Boss.GetComponent<BossHP>().healthText.SetActive(true);
            time.GetComponent<Text>().enabled = true;
            time.GetComponent<Text>().text = "Time: " + timer;
        }
        if(timer <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            boss = true;
            Debug.Log("hi");
        }
    }
}
