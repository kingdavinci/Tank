using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ammo : MonoBehaviour
{
    public int Missles;
    public GameObject AmmoText;
    
    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs.SetInt("TotalAmmo", Missles);
        Missles = PlayerPrefs.GetInt("TotalAmmo");
        
    }

    // Update is called once per frame
    void Update()
    {
        Missles = PlayerPrefs.GetInt("TotalAmmo");
        AmmoText.GetComponent<Text>().text = "Ammo:" + Missles;
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ammo")
        {
            PlayerPrefs.SetInt("TotalAmmo", Missles + 1);
            Destroy(collision.gameObject);
        }
    }
}
