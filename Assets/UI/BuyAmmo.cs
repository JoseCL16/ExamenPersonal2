using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAmmo : MonoBehaviour
{
    public Button button;
    public int price;

    public void Awake()
    {
        button = GetComponent<Button>();
    }


    void Start()
    {
        button.onClick.AddListener(Buy);
    }


    void Buy()
    {
        if (CoinCount.coinAmount >= price)
        {
            CoinCount.coinAmount -= price;
            AmmoCountUzi.Ammo = 30;
            UziShoot.Ammo = 30;
        }

        if (CoinCount.coinAmount <= 0)
        {
            CoinCount.coinAmount = 0;
        }
    }
}
