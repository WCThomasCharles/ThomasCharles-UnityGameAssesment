using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBehaviour : MonoBehaviour
{
    public PinManager pinsManager; // the manager assigned to govern this pins stack
    public GameManager gameManager;

    private BoxCollider2D hb; // the pins hitbox
    private Rigidbody2D rb; // the pins rigidbody2D


    // Start is called before the first frame update
    void Start()
    {
        hb = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }


    // Called when the player enters a collider
    private void OnCollisionEnter2D(Collision2D collider)
    {
        // checks if the collider is tagged player
        if (collider.gameObject.CompareTag("Player"))
        {
            // turns off hitbox, blows up the player, calls the manager to launch all the pins in the stack, and shows the victory screen
            hb.enabled = false;
            collider.gameObject.GetComponent<PlayerBehaviour>().ExplodeSelf();
            pinsManager.LaunchAllPins(collider.gameObject.transform.position);
            gameManager.ShowVictoryScreen();
        }
    }


    public void LaunchSelfFromPlayer(Vector3 playerPosition)
    {
        rb.AddForce((transform.position - playerPosition) * 50, ForceMode2D.Impulse);
    }
}
