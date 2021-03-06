using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Alexander
{
    public class Gun : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public Transform bulletSpawnTransform;

        public int ammo = 10000;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetAxis("Fire1") > 0f)
            {
                if (ammo > 0)
                {
                    GameObject bullet = Instantiate(bulletPrefab, bulletSpawnTransform.position, bulletSpawnTransform.rotation);
                    ammo--;
                }
            }
        }
    }
}