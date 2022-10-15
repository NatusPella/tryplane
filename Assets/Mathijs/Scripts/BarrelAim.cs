using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelAim : MonoBehaviour
{
    GameObject playerEntity;
    float sensingDistance = 10.0f;

    void Awake()
    {
        playerEntity = GameObject.FindGameObjectWithTag("Player");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 planePosition = playerEntity.transform.position;

        float distanceTowardsPlayer = Vector2.Distance(planePosition, transform.position);

        if (distanceTowardsPlayer <= sensingDistance)
        {
            transform.right = planePosition - (Vector2)transform.position;
        } else {
            transform.right = Vector3.right;
        }
    }
}
