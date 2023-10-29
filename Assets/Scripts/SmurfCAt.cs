using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmurfCAt : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D col;

    public float jumpVelocity;
    public float speed;
    public bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newVel = rb.velocity;
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            newVel.y = jumpVelocity;
            canJump = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newVel.x = -speed;
        } 
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            newVel.x = speed;
        }
        rb.velocity = newVel;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
        canJump = true;
    }
}
