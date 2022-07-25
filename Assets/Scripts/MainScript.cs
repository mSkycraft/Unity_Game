using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public static bool GameStarted = false;
    public GameObject StartMenu;
    public GameObject PauseMenu;
    public GameObject GameMenu;
    public Image Shield1;
    public Image Shield2;
    public Button ShieldButton;
    private float ShieldCd = 15,CurrentShieldCd;
    public GameObject TimerBack;
    public GameObject TimerText;
    public Text Timer;

    public void Start()
    {
        StartMenu.SetActive(true);
        PauseMenu.SetActive(false);
        GameMenu.SetActive(false);
        TimerBack.SetActive(false);
        TimerText.SetActive(false);
    }

    public void PlayButton()
    {
        StartMenu.SetActive(false);
        PauseMenu.SetActive(false);
        GameMenu.SetActive(true);
        GameStarted = true;
    }

    public void ExitButton()
    {
        Application.Quit(0);
    }
    public void PauseButton()
    {

        GameStarted = false;
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    public void ShieldActivate()
    {
        ShieldButton.interactable = false;
        CurrentShieldCd = ShieldCd;
        ShieldScript2.ShieldActive = true;
        TimerBack.SetActive(true);
        TimerText.SetActive(true);
        Timer.text = "0:" + CurrentShieldCd.ToString();
    }


    private void Update()
    {
        if(GameStarted == true)
        {
            if (CurrentShieldCd <= 0)
            {
                ShieldButton.interactable = true;
                TimerBack.SetActive(false);
                TimerText.SetActive(false);
            }
            else
            {
                if (CurrentShieldCd <= 5)
                {
                    Shield2.fillAmount = 0;
                }
                CurrentShieldCd -= Time.deltaTime;
                Timer.text = "0:" + ((int)Mathf.Round(CurrentShieldCd)).ToString("d2");
            }
        }
    }
}
