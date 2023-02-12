using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pause_Menu;
   public void Pause()
    {
        Time.timeScale = 0f;
        Pause_Menu.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        Pause_Menu.SetActive(false);
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
