using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Tryplane.Alexander
{
    public class RenderAltitude : MonoBehaviour
    {
        public GameObject gameObjectToDisplay;
        private TMP_Text text;

        // Start is called before the first frame update
        void Start()
        {
            text = GetComponent<TMP_Text>();
        }

        // Update is called once per frame
        void Update()
        {
            if (gameObjectToDisplay != null)
            {
                text.text = "Altitude: " + (gameObjectToDisplay.transform.position.y - 1);
            }
        }
    }
}