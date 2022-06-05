using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tryplane.Alexander
{
    public class Restart : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetButtonDown("Reset"))
            {
                restart();
            }
        }

        private void restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}