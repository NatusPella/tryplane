using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Mathijs
{
    public class Flip : MonoBehaviour
    {
        new private Rigidbody2D rigidbody2D;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);


            }
        }
    }
}