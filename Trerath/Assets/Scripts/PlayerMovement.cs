using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 15;
    public float Gravity = 5f;
    private Rigidbody rb;

    //[SerializeField]
    //private float speed;
    //public float Speed => speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        // rb.AddForce(Physics.gravity, ForceMode.Acceleration);
    }

    void FixedUpdate()
    {
        // Move the player
        rb.velocity =
            transform.InverseTransformDirection(
                new Vector3(
                    Input.GetAxis("Horizontal") * Speed,
                    -1f * Gravity,
                    Input.GetAxis("Vertical") * Speed
                )
              );
    }
}
