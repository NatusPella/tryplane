using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    private float forcedHorizontalSpeed = 5f;
    private float lift = 25f;
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody2D.AddForce(Vector2.right * forcedHorizontalSpeed);

        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.AddForce(Vector2.up * lift);
        }

        Vector2 moveDirection = rigidbody2D.velocity;
        if (moveDirection != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
