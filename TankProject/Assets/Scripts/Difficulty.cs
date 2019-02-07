using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour {
    public int diff =1;

	// Use this for initialization
	void Start () {
         PlayerPrefs.SetInt("Difficulty", diff);
        diff = PlayerPrefs.GetInt("Difficulty");
        Debug.Log(diff);
    }

    // Update is called once per frame
    void Update () {
        PlayerPrefs.SetInt("Difficulty", diff);
       // diff = PlayerPrefs.GetInt("Difficulty");
    }
    void ModifyDifficulty(int mod)
    {
        diff += mod;
    }
}
