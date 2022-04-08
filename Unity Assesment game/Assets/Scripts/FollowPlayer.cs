using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform playerLocation;
    public float zOffset;

    // Start is called before the first frame update
    void Start()
    {
        playerLocation = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLocation != null)
        {
            transform.position = playerLocation.position + new Vector3 (0, 0, -zOffset);
        }
    }
}
