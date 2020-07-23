using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    private const string GAME_SCENE_NAME = "Game";
    private const string MAIN_MENU_SCENE_NAME = "MainMenu";

    public void LoadGame()
    {
        SceneManager.LoadScene(GAME_SCENE_NAME);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MAIN_MENU_SCENE_NAME);
    }
}
