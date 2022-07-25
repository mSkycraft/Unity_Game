using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class UIScript : MonoBehaviour
{
    public Button restartBtn;
    public Button resumeBtn;
    public GameObject pausemenu;


    private void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        restartBtn = root.Q<Button>("RestartButton");
        resumeBtn = root.Q<Button>("ResumeButton");

        restartBtn.clicked += RestartBtnPressed;
        resumeBtn.clicked += ResumeBtnPressed;
    }

    public void RestartBtnPressed()
    {
        SceneManager.LoadScene("Game");
        pausemenu.SetActive(false);
    }

    public void ResumeBtnPressed()
    {
        MainScript.GameStarted = true;
        Time.timeScale = 1;
        pausemenu.SetActive(false);
    }
}
