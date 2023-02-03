using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
