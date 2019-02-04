using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerShoot : MonoBehaviour {
 
    public GameObject prefab;
    public float shootSpeed = 0;
    float timer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
       
		if(Input.GetButton("Fire1") && timer > 0.2f)
        {
            timer = 0;
            var mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = -10;
            // when calculating a vector from point a to b , always do destination - start position
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            Vector3 offset = shootDir;
            shootDir = shootDir * shootSpeed;
            GameObject bullet = (GameObject)Instantiate(prefab,
                transform.position + offset, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir;
            Destroy(bullet, 0.5f);
        }
	}
}
