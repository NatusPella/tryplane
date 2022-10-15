using System.Collections;
using UnityEngine;

public class DrivingAround : MonoBehaviour
{
    AudioSource tankDriving;

    private void Awake()
    {
        tankDriving = GetComponent<AudioSource>();
    }

    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomDistanceAndDirection());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator RandomDistanceAndDirection()
    {
        // Bepaal een richting
        // Bepaal een afstand
        // Rijdt per frame die kant op
        // Als je er bent wordt er weer een nieuwe positie en richting bepaald

        Vector2 endPosition = new Vector2(transform.position.x + Random.Range(-10f, 10f), transform.position.y);

        float drivingVolume = transform.localScale.x;
        float idleVolume = drivingVolume / 4;

        tankDriving.volume = drivingVolume;

        while (true)
        {
            if (Vector2.Distance(transform.position, endPosition) < 0.1f || endPosition == Vector2.zero)
            {
                endPosition = new Vector2(transform.position.x + Random.Range(-50f, 50f), transform.position.y);

                tankDriving.volume = idleVolume;

                yield return new WaitForSeconds(2);
                tankDriving.volume = drivingVolume;
            }
            else
            {
                if (endPosition.x - transform.position.x > 0) {
                    transform.localScale = new Vector2(-Mathf.Abs(transform.localScale.x), transform.localScale.y);
                } else {
                    transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);
                }
                

                float step = speed * Time.deltaTime; // calculate distance to move
                transform.position = Vector3.MoveTowards(transform.position, endPosition, step);

                yield return null;
            }
        }
    }
}
