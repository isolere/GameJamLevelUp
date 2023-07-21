using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);

    }

    public void LoadVictory()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);

    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);

    }

    public void QuitGame()
    {
        Application.Quit();
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
