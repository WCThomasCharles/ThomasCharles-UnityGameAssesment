using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public ParticleSystem explosion;

    private Rigidbody2D rb;
    private float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector3(1, 0, 0) * speed * horizontalInput * Time.deltaTime);
    }
    public void Explode()
    {
        explosion.Play();
        Destroy(gameObject);
    }
}