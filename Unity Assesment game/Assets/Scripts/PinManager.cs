using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinManager : MonoBehaviour
{
    public GameObject[] pins; // a list of all the pins under this manager

    public void LaunchAllPins(Vector3 playerPosition)
    {
        foreach (GameObject pin in pins)
        {
            pin.GetComponent<PinBehaviour>().LaunchSelfFromPlayer(playerPosition);
        }
    }
}
