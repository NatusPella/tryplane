using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Alexander
{

    public class March : MonoBehaviour
    {
        private Vector3 startingPoint;

        // Start is called before the first frame update
        void Start()
        {
            startingPoint = transform.position;
            StartCoroutine(MarchCoroutine());
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator MarchCoroutine()
        {
            while (true)
            {
                while (Vector3.Distance(transform.position, startingPoint + new Vector3(-5f, 0, 0)) > 0.1f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, startingPoint + new Vector3(-5f, 0, 0), Time.deltaTime * 2.5f);
                    yield return null;
                }

                yield return null;

                while (Vector3.Distance(transform.position, startingPoint + new Vector3(5f, 0, 0)) > 0.1f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, startingPoint + new Vector3(5f, 0, 0), Time.deltaTime * 2.5f);
                    yield return null;
                }
            }
        }
    }

}