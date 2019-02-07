using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuButtons : MonoBehaviour
{
    public GameObject UI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            //if is pressed stop stuff from moving
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                //make pause menu visible
                UI.GetComponent<Canvas>().enabled = false;
                GetComponent<Canvas>().enabled = true;
            }
            else if (Time.timeScale == 0)
            {
                UI.GetComponent<Canvas>().enabled = true;
                //unpause
                Resume();
            }
        }
    }

    public void QuitGame()
    {
        UI.GetComponent<Canvas>().enabled = true;
        Application.Quit();
    }

    public void Resume()
    {
        UI.GetComponent<Canvas>().enabled = true;
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        UI.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
