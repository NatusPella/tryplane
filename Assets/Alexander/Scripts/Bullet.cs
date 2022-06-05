using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Alexander
{
    public class Bullet : MonoBehaviour
    {
        public float bulletSpeed = 100f;

        // Start is called before the first frame update
        void Start()
        {
            Destroy(gameObject, 1.5f);
        }

        // Update is called once per frame
        void Update()
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Bullet"))
            {
                return;
            }

            if (other.gameObject.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);
                //Debug.Log("Deleted enemy");
            }

            Destroy(gameObject);
        }
    }
}