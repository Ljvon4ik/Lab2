using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;
    public float zBoundUp = 13f;
    public float zBoundDown = -1f;
    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();
    }

    //basic player movement
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticallInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * horizontalInput * speed);
        playerRb.AddForce(Vector3.forward * verticallInput * speed);
    }

    //restriction of the player's movement from above and below
    void ConstrainPlayerPosition()
    {
        if (transform.position.z > zBoundUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundUp);
        }

        if (transform.position.z < zBoundDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundDown);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Collision");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }
}
