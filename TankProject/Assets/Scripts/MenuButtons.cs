using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject DiffMenu;
    public GameObject Cam;
    public GameObject UI;
    public GameObject HTPUI;
    public string Map;
    void Update()
    {
        // check to see if p key is pressed
       /* if (Input.GetKeyDown(KeyCode.P))
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
        }*/
    }

    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

   /* public void QuitGame()
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
    */
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
        Cam.GetComponent<Difficulty>().diff = 1;
        Debug.Log(Cam.GetComponent<Difficulty>().diff);
        DiffMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void Medium()
    {
        Cam.GetComponent<Difficulty>().diff = 2;
        Debug.Log(Cam.GetComponent<Difficulty>().diff);
        DiffMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void Hard()
    {
        Cam.GetComponent<Difficulty>().diff = 3;
        Debug.Log(Cam.GetComponent<Difficulty>().diff);
        DiffMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void ToDiffScene()
    {
        SceneManager.LoadScene(Map);
    }
    public void HelpAppear()
    {
        HTPUI.GetComponent<Canvas>().enabled = true;
        UI.GetComponent<Canvas>().enabled = false;

    }
    public void HelpDisappear()
    {
        UI.GetComponent<Canvas>().enabled = true;
        HTPUI.GetComponent<Canvas>().enabled = false;
    }

}
