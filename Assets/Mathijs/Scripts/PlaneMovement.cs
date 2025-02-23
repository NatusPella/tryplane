using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tryplane.Mathijs
{
    public class PlaneMovement : MonoBehaviour
    {
        private float forcedHorizontalSpeed = 15f;
        new private Rigidbody2D rigidbody2D;

        private float velocity;
        private float magnitude;
        private float maxEngineSpeed = 30f;

        public bool engineOn = true;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (GetComponent<Flip>().isFlipped)
            {
                transform.RotateAround(transform.position, Vector3.forward, 5f * Input.GetAxis("Vertical"));

            }
            else
            {
                transform.RotateAround(transform.position, Vector3.forward, 5f * -Input.GetAxis("Vertical"));

            }

            if (engineOn)
            {
                if (rigidbody2D.linearVelocity.x < maxEngineSpeed)
                {
                    rigidbody2D.linearVelocity = transform.right * forcedHorizontalSpeed;
                }
            }
        }



        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                engineOn = !engineOn;
            }
        }

    }
}

