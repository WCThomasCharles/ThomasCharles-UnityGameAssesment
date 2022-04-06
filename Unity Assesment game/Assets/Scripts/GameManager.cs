using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // The current canvas to display
    // - 0 is the start screen
    // - 1 is the level selector
    private int canavsToDisplay = 0;

    public GameObject startScreen;
    public GameObject levelSelect;

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "TitleScreen")
        {
            if (canavsToDisplay == 0) startScreen.SetActive(true);
            else if (canavsToDisplay != 0) startScreen.SetActive(false);

            if (canavsToDisplay == 1) levelSelect.SetActive(true);
            else if (canavsToDisplay != 1) levelSelect.SetActive(false);
        }
    }

    public void SetCanvas(int canvasNumber)
    {
        canavsToDisplay = canvasNumber;
    }

    public void GoToScene(string sceneToActivate)
    {
        SceneManager.LoadScene(sceneToActivate);
    }

    public void ShowVictoryScreen()
    {

    }
}
