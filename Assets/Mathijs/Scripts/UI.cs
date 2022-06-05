using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI : MonoBehaviour
{

    public GameObject gameObjectToDisplay;
    private TMP_Text airSpeedDisplay;
    // Start is called before the first frame update
    void Start()
    {
        airSpeedDisplay = GetComponent<TMP_Text>();
    }
    // Update is called once per frame
    void Update()
    {
        if (gameObjectToDisplay != null)
        {
            airSpeedDisplay.text = "Airspeed: " + (gameObjectToDisplay.GetComponent<Rigidbody2D>().velocity.magnitude);
        }
    }
}
