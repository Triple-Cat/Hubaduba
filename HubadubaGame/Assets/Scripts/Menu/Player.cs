using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Image playerImage;
    public Image image;


    private void Start()
    {
        playerImage = image;
    }
}
