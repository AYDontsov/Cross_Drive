using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySlowCoints : MonoBehaviour
{
    private int countCoins;
    public void BuySlow(int needCoins) {
        countCoins = PlayerPrefs.GetInt("Slow");

    }
}
