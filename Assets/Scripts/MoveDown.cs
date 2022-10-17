using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    private float downBottom = -6f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.back * speed);

        if(transform.position.z < downBottom)
        {
            Destroy(gameObject);
        }
    }
}
