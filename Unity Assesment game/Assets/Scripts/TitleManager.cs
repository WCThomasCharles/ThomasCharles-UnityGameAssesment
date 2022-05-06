using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject startScreen; // The screen that displays the title and the "Start" and "Tutorial" buttons
    public GameObject levelSelect; // The screen that allows the user to pick a level

    // The various screens used in the tutorial sequence
    public GameObject tutorialScreen1;
    public GameObject tutorialScreen2;
    public GameObject tutorialScreen3;
    public GameObject tutorialScreen4;

    // Switch canvas is the function that is called by buttons on the title screen that change what is displayed
    // it takes one argument, the number that corresponds to the screen the button is suppose to switch to
    public void SwitchCanvas(int canvasToDisplay)
    {
        // - 0 is the start screen
        // - 1 is the level selector
        // - 2, 3, 4, and 5 are tutorial screens 1, 2, 3, and 4 respectivley 

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

        if (canvasToDisplay == 5) tutorialScreen4.SetActive(true);
        else if (canvasToDisplay != 5) tutorialScreen4.SetActive(false);
    }

    // GoToScene is a function that can be called by buttons to switch scenes
    // it takes the name of the scene the button switches to as an argument
    public void GoToScene(string sceneToActivate)
    {
        SceneManager.LoadScene(sceneToActivate);
    }
}
