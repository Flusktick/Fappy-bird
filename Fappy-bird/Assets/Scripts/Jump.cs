using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    [SerializeField] private float JumpForce =3f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = transform.up * JumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Has Collided");
    }

}
