using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Mathijs
{
    public class Flip : MonoBehaviour
    {

public bool isFlipped = false;

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
            if (isFlipped)
            {
                isFlipped = false;
                rigidbody2D.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            else
            {
                isFlipped = true;
                rigidbody2D.transform.localScale = new Vector3(0.5f, -0.5f, 0.5f);
            }
        }
    }
}