using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    private const string GAME_SCENE_NAME = "Level1";
    private const string MAIN_MENU_SCENE_NAME = "MainMenu";

    public void LoadGame()
    {
        SetTimeScale(1.0f);
        SceneManager.LoadScene(GAME_SCENE_NAME);
    }

    public void PlayAgain()
    {
        SetTimeScale(1.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MAIN_MENU_SCENE_NAME);
    }

    public void LoadNextLevel()
    {
        SetTimeScale(1.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void SetTimeScale(float variable)
    {
        Time.timeScale = variable;
    }
}
