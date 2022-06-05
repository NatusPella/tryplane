using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Alexander
{
    public class TrackGameObjectAbsolute : MonoBehaviour
    {

        public GameObject gameObjectToTrack;
        public Vector3 axes;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (gameObjectToTrack == null)
            {
                return;
            }

            transform.position = new Vector3(
                axes.x > 0 ? gameObjectToTrack.transform.position.x : transform.position.x,
                axes.y > 0 ? gameObjectToTrack.transform.position.x : transform.position.y,
                axes.z > 0 ? gameObjectToTrack.transform.position.x : transform.position.z
            );
        }
    }
}