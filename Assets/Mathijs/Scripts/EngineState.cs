using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace Tryplane.Mathijs
{
    public class EngineState : MonoBehaviour
    {
        public GameObject gameObjectToDisplay;
        private TMP_Text engineStateDisplay;
        // Start is called before the first frame update
        void Start()
        {
            engineStateDisplay = GetComponent<TMP_Text>();
        }
        // Update is called once per frame
        void Update()
        {
            if (gameObjectToDisplay != null)
            {
                engineStateDisplay.text = "Engine: " + (gameObjectToDisplay.GetComponent<PlaneMovement>().engineOn? "On" : "Off");
            }
        }
    }
}