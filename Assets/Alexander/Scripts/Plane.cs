using UnityEngine;

namespace Tryplane.Alexander
{
    public class Plane : MonoBehaviour
    {
        public GameObject destroyedPrefab;
        private float power = 25f;
        new private Rigidbody2D rigidbody2D;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();

            rigidbody2D.AddForce(Vector2.right * 1000f);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            rigidbody2D.AddForce(Vector2.up * Input.GetAxis("Vertical") * power);
            rigidbody2D.AddForce(Vector2.right * Input.GetAxis("Horizontal") * power);

            Vector2 moveDirection = rigidbody2D.velocity;
            if (moveDirection != Vector2.zero)
            {
                float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Bullet"))
            {
                return;
            }

            Explode(collision.contacts[0].point);
        }

        public void Explode(Vector3 position)
        {
            Instantiate(destroyedPrefab, position, transform.rotation);
            Destroy(gameObject);
        }

    }
}