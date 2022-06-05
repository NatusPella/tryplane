using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Alexander
{
    public class TrackGameObjectByTag : MonoBehaviour
    {

        public string tag;
        public Vector3 offset;

        private GameObject gameObjectToTrack;

        // Start is called before the first frame update
        void Start()
        {
            FindGameObjectWithTag();
        }

        // Update is called once per frame
        void Update()
        {
            if (gameObjectToTrack == null)
            {
                FindGameObjectWithTag();
                return;
            }

            transform.position = gameObjectToTrack.transform.position + offset;
        }

        void FindGameObjectWithTag()
        {
            gameObjectToTrack = GameObject.FindGameObjectWithTag(tag);
        }
    }
}