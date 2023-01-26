using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void OpenImprovementShop()
    {
        SceneManager.LoadScene("Improvement_shop");
    }

    public void OpenShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void ArcheryShopOpen()
    {
        SceneManager.LoadScene("ArcheryShop");
    }

    public void ArrowShopOpen()
    {
        SceneManager.LoadScene("ArrowShop");
    }

    public void DevelopersInfoOpen()
    {
        SceneManager.LoadScene("DevelopersInfo");
    }
}
