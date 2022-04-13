using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject victoryScreen; // The screen to show when the player wins
    public GameObject gameOverScreen; // The screen to show when the player loses

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("r"))
        {
            RestartThisLevel();
        }
    }

    // GoToScene is a function that can be called by buttons to switch scenes
    // it takes the name of the scene the button switches to as an argument
    public void GoToScene(string sceneToActivate)
    {
        SceneManager.LoadScene(sceneToActivate);
    }


    // RestartThisLevel loads the current scene reseting it to the start
    // It is called by the restart buttons
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
