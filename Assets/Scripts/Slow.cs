using UnityEngine.UI;
using UnityEngine;
using System;
using System.Collections;


public class Slow : MonoBehaviour
{
    public AudioSource slow;
    public AudioClip click;
    public Text attempt;
    public Sprite noAttempt;
    private Image image;
    private bool nowSlow;


    private void Start()
    {
        image = GetComponent<Image>();
        Time.timeScale = 1f;
    }
    public void SlowButton()
    { 
        if (PlayerPrefs.GetInt("Slow") > 0 && !nowSlow && !CarController.isLose)
        {
            Time.timeScale = 0.5f;
            int i = PlayerPrefs.GetInt("Slow");
            i--;
            PlayerPrefs.SetInt("Slow",i); 
            slow.PlayOneShot(click);
            nowSlow = true;
        }
        else if (PlayerPrefs.GetInt("Slow") <= 0) {
            image.sprite = noAttempt;
        }    
    }
    private void Update()
    {
        attempt.text = PlayerPrefs.GetInt("Slow").ToString();
        if (nowSlow && !CarController.isLose)
        {
            GetComponent<Button>().interactable = false;
            Invoke("nowTime",2f);
        }else if(!nowSlow && !CarController.isLose)
            GetComponent<Button>().interactable = true;
        if(PlayerPrefs.GetInt("Slow") == 0 || CarController.isLose)
            GetComponent<Button>().interactable = false;

    }
    void nowTime() {
        nowSlow = false;
        Time.timeScale = 1f;
    }


}
