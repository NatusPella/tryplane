using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Tryplane.Alexander
{
    public class RenderSpeed : MonoBehaviour
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
                text.text = "Speed: " + (gameObjectToDisplay.GetComponent<Rigidbody2D>().linearVelocity.magnitude * 10).ToString("N0") + "kmph";
            }
        }
    }
}