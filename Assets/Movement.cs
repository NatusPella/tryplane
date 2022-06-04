using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float initialSpeed = 25f;
    private float boosterSpeed = 5f;
    private Rigidbody2D rigidbody2D;
    private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {




        Debug.Log(rigidbody2D.velocity);


        float horizontalVelocity = Vector2.Dot(rigidbody2D.velocity, Vector2.right);

        float verticalVelocity = Vector2.Dot(rigidbody2D.velocity, Vector2.up);



        if (horizontalVelocity < -1)
        {
            facingRight = false;
            transform.localRotation = Quaternion.Euler(0, 270, 0);
        }
        else
        {
            facingRight = true;
            transform.localRotation = Quaternion.Euler(0, 90, 0);
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
