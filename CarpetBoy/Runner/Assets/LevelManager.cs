using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManagerSingleton;
    [SerializeField] GameObject PausePanel;

    private int[] roadNumber;

    public int[] RoadNumber { get => roadNumber; set => roadNumber = value; }

    private void Start()
    {
        Pause();

        RoadNumber= new int[3];

        RoadNumber[0] = 10;
        RoadNumber[1] = 20;
        RoadNumber[2] = 30;

    }
    private void Awake()
    {
        levelManagerSingleton = this;
    }

    public void GameOver()
    {

    }
    public void ResetGame()
    {
        SceneManager.LoadScene("RoadBuilder");
    }
    public void Pause()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);


    }
    public void Resume()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);

    }

}
