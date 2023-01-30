using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject GameObjectClosed;
    public GameObject GameObjectOpen;
    public void OpenNewMenu()
    {
        GameObjectClosed.SetActive(false);
        GameObjectOpen.SetActive(true);
    }
}
