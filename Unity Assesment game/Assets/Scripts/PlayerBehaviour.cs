using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public ParticleSystem explosion; // the particle system to be played when the player explodes
    public GameManager gameManager; // the gamemanager object

    private Rigidbody2D rb; // the players RigidBody2D
    private float speed = 100.0f; // The players speed, this is whats added when they move

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        // Gets the players inputs on the horizontal axis and then moves them along it
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector3(1, 0, 0) * speed * horizontalInput * Time.deltaTime);
    }


    // Explode self is called by other things to indicate the level is over
    // It runs when the player has died or won
    public void ExplodeSelf()
    {
        explosion.Play();
        Destroy(gameObject);
    }
    
    
    // Called when the player enters a trigger collider
    void OnTriggerEnter2D(Collider2D collider)
    {
        // checks if the collider is tagged "Kill Box"
        if(collider.CompareTag("Kill Box"))
        {
            gameManager.ShowGameOverScreen();
            ExplodeSelf();
        }
    }
}
