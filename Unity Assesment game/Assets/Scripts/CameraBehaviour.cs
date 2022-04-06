using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    private GameObject player;
    private Vector2 playerVelocity;
    private Vector3 cameraOffset = new Vector3(0, 0, -10);
    private Camera cameraComponent;
    private float minSize = 5.0f;
    private float maxSize = 5.5f;
    private float xOffsetBound = 1.0f;
    private float yOffsetBound = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        cameraComponent = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            playerVelocity = player.GetComponent<Rigidbody2D>().velocity;
            cameraOffset.x = playerVelocity.x;
            cameraOffset.y = playerVelocity.y;

            if (cameraOffset.x > xOffsetBound) cameraOffset.x = xOffsetBound;
            if (cameraOffset.x < -xOffsetBound) cameraOffset.x = -xOffsetBound;
            if (cameraOffset.y > yOffsetBound) cameraOffset.y = yOffsetBound;
            if (cameraOffset.y < -yOffsetBound) cameraOffset.y = -yOffsetBound;

            transform.position = player.transform.position + cameraOffset;
            cameraComponent.orthographicSize = Mathf.Abs(playerVelocity.x) + Mathf.Abs(playerVelocity.y);
            if (cameraComponent.orthographicSize < minSize)
            {
                cameraComponent.orthographicSize = minSize;
            }
            else if (cameraComponent.orthographicSize > maxSize)
            {
                cameraComponent.orthographicSize = maxSize;
            }
        }
    }
}
