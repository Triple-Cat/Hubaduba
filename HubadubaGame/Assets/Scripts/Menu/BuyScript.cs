using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyScript : MonoBehaviour
{
    public GameObject locker;
    public GameObject checker;

    public Button button;

    public int price;
    public Image image;


    public bool IsEquip = false;
    public bool IsBought = false;
  
    public void Purchase()
    {
        
        if (IsBought == false)
        {
            if (Confirmation.suggestion == false)
            {
                checker.SetActive(true);
            }
            else
            {
                if (price <= MoneyManager.money)
                {
                    IsBought = true;
                    IsEquip = true;
                    locker.SetActive(false);
                    MoneyManager.money -= price;
                    Debug.Log($"вы экипировали {image.name}");
                    Player.playerImage = image;

                }
                else
                {
                    Debug.Log("у вас недостаточно денег для покупки");
                }
                Confirmation.suggestion = false;
            }
        }
        else
        {
            Player.playerImage = image;
            IsEquip = true;
            Debug.Log($"вы экипировали {image.name}");
        }
    }
    private void Update()
    {
        if (image != Player.playerImage)
        {
            IsEquip = false;
        }
    }
}
