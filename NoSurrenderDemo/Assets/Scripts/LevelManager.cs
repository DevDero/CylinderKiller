using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public enum ControlerType { Joystick, TouchToGo }

    public ControlerType ConfigedControler;

    public static LevelManager levelManager;
    [SerializeField] GameObject gameoverPanel,settingsPanel,ClickToGoPanel;


    private void Start()
    {
          levelManager=this;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        settingsPanel.SetActive(true);
        ClickToGoPanel.SetActive(false);

    }
    public void GameResume()
    {
        Time.timeScale = 1;
        settingsPanel.SetActive(false);
        gameoverPanel.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameoverPanel.SetActive(true);
    }

    public void LevelRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void Resume()
    {

    }

}
