using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform playerLocation; // The players current position
    public float zOffset; // The distance from the player on the Z axis that the object should be; used to make sure the camera can see everything


    // Start is called before the first frame
    void Start()
    {
        // Sets the players location to the current transform.postion of the player
        playerLocation = GameObject.Find("Player").GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
        // checks if there is a player
        // this is in order to prevent errors flooding the console when the player is destroyed
        if (playerLocation != null)
        {
            // moves to the players position considering the offset
            transform.position = playerLocation.position + new Vector3(0, 0, -zOffset);
        }
    }
}
