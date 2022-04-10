using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject levelSelect;

    public GameObject tutorialScreen1;
    public GameObject tutorialScreen2;
    public GameObject tutorialScreen3;

    public void SwitchCanvas(int canvasToDisplay)
    {
        // - 0 is the start screen
        // - 1 is the level selector
        // - 2, 3, and 4 are tutorial screens 1, 2, and 3

        if (canvasToDisplay == 0) startScreen.SetActive(true);
        else if (canvasToDisplay != 0) startScreen.SetActive(false);

        if (canvasToDisplay == 1) levelSelect.SetActive(true);
        else if (canvasToDisplay != 1) levelSelect.SetActive(false);

        if (canvasToDisplay == 2) tutorialScreen1.SetActive(true);
        else if (canvasToDisplay != 2) tutorialScreen1.SetActive(false);

        if (canvasToDisplay == 3) tutorialScreen2.SetActive(true);
        else if (canvasToDisplay != 3) tutorialScreen2.SetActive(false);

        if (canvasToDisplay == 4) tutorialScreen3.SetActive(true);
        else if (canvasToDisplay != 4) tutorialScreen3.SetActive(false);
    }

    public void GoToScene(string sceneToActivate)
    {
        SceneManager.LoadScene(sceneToActivate);
    }
}
