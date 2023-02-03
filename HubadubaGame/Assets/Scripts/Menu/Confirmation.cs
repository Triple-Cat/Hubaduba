using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Confirmation : MonoBehaviour
{
    public GameObject panel;
    public bool checker;
    public static bool suggestion = false;

    public void Confirm()
    {
        if (checker == true)
        {
            suggestion = true;
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
