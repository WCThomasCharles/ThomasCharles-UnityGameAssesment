using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBehaviour : MonoBehaviour
{
    public PinManager pinsManager;
    private GameManager gameManager;

    private BoxCollider2D hb;
    private Rigidbody2D rb;

    void Start()
    {
        hb = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            hb.enabled = false;
            collider.gameObject.GetComponent<PlayerBehaviour>().Explode();
            pinsManager.LaunchAllPins(collider.gameObject.transform.position);
            gameManager.ShowVictoryScreen();
        }
    }

    public void LaunchSelfFromPlayer(Vector3 playerPosition)
    {
        rb.AddForce((transform.position - playerPosition) * 50, ForceMode2D.Impulse);
    }
}