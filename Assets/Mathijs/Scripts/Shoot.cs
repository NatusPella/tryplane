using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float offset = 1.5f;
    public float bulletForce = 2500f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 spawnPosition = (Vector2)transform.position + ((Vector2)transform.right * offset);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject goBullet = Instantiate(bullet, spawnPosition, Quaternion.identity);
            AudioSource firingSound = GetComponent<AudioSource>();
            
            
            firingSound.Play();
            
            goBullet.GetComponent<Rigidbody2D>().AddForce(((Vector2)transform.right * bulletForce));
        }
    }
}
