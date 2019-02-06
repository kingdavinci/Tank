using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject DiffMenu;
    void Update()
    {
        // check to see if p key is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {

            //if is pressed stop stuff from moving
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                //make pause menu visible
                GetComponent<Canvas>().enabled = true;
            }
            else if (Time.timeScale == 0)
            {
                //unpause
                Resume();
            }
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Resume()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void DiffMenuOn()
    {
        MainMenu.SetActive(false);
        DiffMenu.SetActive(true);
    }
    /*public void DiffMenuOff()
    {
        DiffMenu.SetActive(false);
        MainMenu.SetActive(true);
    }*/
    public void Easy()
    {
        DiffMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void Hard()
    {
        DiffMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

}
