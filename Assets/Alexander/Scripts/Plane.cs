using UnityEngine;

namespace Tryplane.Alexander
{
    public class Plane : MonoBehaviour
    {
        public GameObject destroyedPrefab;

        private float forcedHorizontalSpeed = 5f;
        private float power = 25f;
        new private Rigidbody2D rigidbody2D;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();

            rigidbody2D.AddForce(Vector2.right * forcedHorizontalSpeed * 100f);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            //rigidbody2D.AddForce(Vector2.right * forcedHorizontalSpeed);

            rigidbody2D.AddForce(Vector2.up * Input.GetAxis("Vertical") * power);
            rigidbody2D.AddForce(Vector2.right * Input.GetAxis("Horizontal") * power);

            Vector2 moveDirection = rigidbody2D.velocity;
            if (moveDirection != Vector2.zero)
            {
                float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }

            if (Input.GetButton("Boost"))
            {
                rigidbody2D.AddForce(transform.right * 100f);
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Bullet"))
            {
                return;
            }

            if (rigidbody2D.velocity.y < -10f)
            {
                Instantiate(destroyedPrefab, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }

    }
}