using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticallInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * horizontalInput * speed);
        playerRb.AddForce(Vector3.forward * verticallInput * speed);
    }
}
