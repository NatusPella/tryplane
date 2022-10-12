using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public AudioClip explosionSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount) {


        GetComponent<AudioSource>().PlayOneShot(explosionSound, 1f);
        
        Destroy(gameObject, explosionSound.length);
    }


}
