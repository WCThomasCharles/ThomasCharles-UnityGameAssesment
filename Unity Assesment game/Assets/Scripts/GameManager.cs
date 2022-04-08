using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject victoryScreen;
    public GameObject gameOverScreen;

    public void GoToScene(string sceneToActivate)
    {
        SceneManager.LoadScene(sceneToActivate);
    }
    public void RestartThisLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ShowVictoryScreen()
    {
        victoryScreen.SetActive(true);
    }
    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
}
