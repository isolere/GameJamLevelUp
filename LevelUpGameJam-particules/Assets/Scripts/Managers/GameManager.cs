using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{/*
    //Amb el codi Header es crea un títol per els serialized fields que fiquem a continuació fins que 
    //insertem un altre

    public delegate void OnEventDelegate();

    public event OnEventDelegate OnLevelChange;

    [Header("Menus")][SerializeField] private string MainMenu = "Main Menu";
    [SerializeField] private string gameOver = "Game Over 1";
    [SerializeField] private string victoryScene = "Victoria";
    [Header("Levels")][SerializeField] private string level01 = "Level 01";


    private static GameManager _instance;

        public static GameManager Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
    }

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

    }*/


    public delegate void OnEventDelegate();

    public event OnEventDelegate OnLevelChange;


    [Header("Menus")] [SerializeField] private string mainMenu = "MainMenu";
    [SerializeField] private string gameOver = "GameOver";
    [SerializeField] private string victoryScene = "Victory";
    // [SerializeField] private string controls = "Controls";
    [Header("Levels")] [SerializeField] private string level01 = "Level 01";


    [Header("Load Delays")]
    [SerializeField]
    private float sceneLoadDelay = 3f;

    [SerializeField] private float sceneDefeatDelay = 3f;
    [SerializeField] private float sceneVictoryDelay = 3f;

    /*
    [Header("Levels")] [SerializeField] private GameLevelsSO gameLevels;


    public static GameLevelsSO GameLevels
    {
        get { return _instance.gameLevels; }
    }
    */

    private static GameManager _instance;

    public static GameManager Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public static void LoadGame()
    {   
        Instance.StartCoroutine(Instance.DelayedLoadLevel(1, Instance.sceneDefeatDelay));
    }

    public static void LoadMainMenu()
    {
        Instance.StartCoroutine(Instance.DelayedLoadLevel(0, Instance.sceneDefeatDelay));
    }



    //codi rectificat per afegir el delay:
    public static void LoadGameOver()
    {       
        // AudioManager.Instance.StopTrack();

        Instance.StartCoroutine(Instance.DelayedLoadLevel(3,Instance.sceneDefeatDelay));

    }

    public static void LoadVictory()
    {

        //   AudioManager.Instance.StopTrack();

        Instance.StartCoroutine(Instance.DelayedLoadLevel(2,Instance.sceneVictoryDelay));
    }
    public static void LoadLevel(string sceneName)
    {

        float delay = Instance.sceneLoadDelay;  // a la variable delay l'hi donem el valor que tenim a la instancia sceneLoadDelay

        Instance.StartCoroutine(Instance.DelayedLoadLevel(1, delay));

    }


    private IEnumerator DelayedLoadLevel(int sceneName, float delay)
    {
        if (OnLevelChange != null) OnLevelChange(); // es comprova que hi hagi el delegat

        yield return new WaitForSeconds(delay); // l'execucio es supen fins que passa el temps que indiquem en delay

        SceneManager.LoadScene(sceneName, LoadSceneMode.Single); // es carrega l'escena

    }

    public static void QuitGame()
    {
        Application.Quit();
    }

}