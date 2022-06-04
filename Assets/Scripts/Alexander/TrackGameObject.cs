using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Alexander
{
    public class TrackGameObject : MonoBehaviour
    {

        public GameObject gameObjectToTrack;
        public Vector3 offset;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.position = gameObjectToTrack.transform.position + offset;
        }
    }
}