using UnityEngine;

namespace Tryplane.Mathijs
{
    public class Movement : MonoBehaviour
    {
        private float initialSpeed = 25f;
        private float boosterSpeed = 5f;
        private Rigidbody2D rigidbody2D;
        private bool facingRight = true;
        private bool inAir = false;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        void

        // Update is called once per frame
        FixedUpdate()
        {
            //Debug.Log(rigidbody2D.velocity);
            //Debug.Log(inAir);

            Debug.Log(rigidbody2D.rotation);

            float horizontalVelocity = Vector2.Dot(rigidbody2D.velocity, Vector2.right);
            float verticalVelocity = Vector2.Dot(rigidbody2D.velocity, Vector2.up);
            float height = transform.position.y;

            inAir = height > 0.5f;

            if (inAir) {

            }

            if (horizontalVelocity < -1)
            {
                facingRight = false;
                //transform.localRotation = Quaternion.Euler(0, 270, transform.localRotation.z);
            }
            else
            {
                facingRight = true;
                //transform.localRotation = Quaternion.Euler(0, 90, transform.localRotation.z);
            }


            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody2D.AddForce(Vector2.right * initialSpeed * Time.fixedDeltaTime);
            }


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody2D.AddForce(Vector2.left * initialSpeed * Time.fixedDeltaTime);

            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                rigidbody2D.AddForce(Vector2.up * initialSpeed * Time.fixedDeltaTime);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                rigidbody2D.AddTorque(10000f * Time.fixedDeltaTime);
            }


            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            {
                initialSpeed += boosterSpeed;
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                initialSpeed -= boosterSpeed;
            }
        }

    }
}