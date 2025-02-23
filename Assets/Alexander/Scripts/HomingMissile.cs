using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Alexander
{
    public class HomingMissile : MonoBehaviour
    {
        public GameObject target;
        public float speed;
        new private Rigidbody2D rigidbody2D;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (target == null)
            {
                Destroy(gameObject);
                return;
            }

            if (
                Vector3.Distance(transform.position, target.transform.position) < 50000000f
            )
            {
                rigidbody2D.linearVelocity = ((Vector2)(target.transform.position - transform.position)).normalized * 40f;

                Vector2 moveDirection = rigidbody2D.linearVelocity;
                if (moveDirection != Vector2.zero)
                {
                    float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                }
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Bullet"))
            {
                return;
            }

            if (collision.gameObject.tag == "Player")
            {
                collision.gameObject.GetComponent<Plane>().Explode(collision.contacts[0].point);
            }
        }
    }
}