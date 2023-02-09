using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool is_paused = false;
    [SerializeField] public GameObject pause_menu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(is_paused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void resume()
    {
        pause_menu.SetActive(false);
        Time.timeScale = 1f;
        is_paused = false;
    }

    void pause()
    {
        pause_menu.SetActive(true);
        Time.timeScale = 0f;
        is_paused = true;
    }

    public void quitToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
