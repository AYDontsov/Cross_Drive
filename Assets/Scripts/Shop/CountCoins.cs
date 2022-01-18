using UnityEngine;
using UnityEngine.UI;

public class CountCoins : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
    }

}
