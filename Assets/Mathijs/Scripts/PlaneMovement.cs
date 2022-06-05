using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tryplane.Mathijs
{
    public class PlaneMovement : MonoBehaviour
    {
        private float forcedHorizontalSpeed = 5f;
        private float power = 5f;
        new private Rigidbody2D rigidbody2D;

        private float velocity;
        private float magnitude;
        private float maxEngineSpeed = 10f;

        private bool engineOn = true;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();

            // Initial force
            rigidbody2D.AddForce(Vector2.right * forcedHorizontalSpeed * 200f);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            rigidbody2D.AddForce(Vector2.up * Input.GetAxis("Vertical") * power);

            Vector2 moveDirection = rigidbody2D.velocity;
            if (moveDirection != Vector2.zero)
            {
                float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }

            if (engineOn)
            {
                rigidbody2D.AddForce(Vector2.right * forcedHorizontalSpeed);
            }

            Debug.Log("Engine is: " + engineOn);
        }

        void Update()
        {
            velocity = rigidbody2D.velocity.magnitude;
            magnitude = rigidbody2D.velocity.magnitude;

            if (Input.GetKey(KeyCode.Return))
            {
                // if (velocity < maxEngineSpeed)
                // {
                //     velocity += acceleration;
                // }

                engineOn = !engineOn;
            }
        }

    }
}

