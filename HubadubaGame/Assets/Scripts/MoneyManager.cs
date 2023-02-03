using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static int money = 1000;
    public TMP_Text text;
    private void Update()
    {
        text.text = $"монеты: {money.ToString()}";
    }
}
