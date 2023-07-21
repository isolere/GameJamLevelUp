using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    [Header("Menus")][SerializeField] private string MainMenu = "Main Menu";
    [SerializeField] private string gameOver = "Game Over 1";
    [SerializeField] private string victoryScene = "Victoria";
    [Header("Levels")][SerializeField] private string level01 = "Level 01";

    private void LoadMainMenu()
    {
        SceneManager.LoadScene(gameOver);
    }

    private void LoadGameOver()
    {
        SceneManager.LoadScene(gameOver);

    }

    private void LoadVictory()
    {
        SceneManager.LoadScene(victoryScene);

    }

    private void LoadLevel()
    {
        SceneManager.LoadScene(level01);

    }

    private void QuitGame()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
