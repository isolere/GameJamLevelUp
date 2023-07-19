using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Amb el codi Header es crea un títol per els serialized fields que fiquem a continuació fins que 
    //insertem un altre

    [Header("Menus")][SerializeField] private string MainMenu = "Main Menu";
    [SerializeField] private string gameOver = "Game Over";
    [SerializeField] private string victoryScene = "Victory";

    [Header("Levels")][SerializeField] private string level01 = "Level 01";

    private void Awake()
    {
    }

    private void LoadGame()
    {

    }

    private void LoadMainMenu()
    {

    }

    private void LoadGameOver()
    {

    }

    private void LoadVictory()
    {

    }

    private void LoadLevel()
    {

    }

    private void QuitGame()
    {

    }
}