using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Tank") {
            
            other.gameObject.GetComponent<Damage>().TakeDamage(100f);
        }

       StartCoroutine(ExplodeAndDestroy());
    }

    private IEnumerator ExplodeAndDestroy()
    {
        AudioSource explosionSound = GetComponent<AudioSource>();

        explosionSound.Play();
        while (explosionSound.isPlaying)
        {
            yield return null;
        }


        Debug.Log("Explode");
        Destroy(gameObject);
    }
}
