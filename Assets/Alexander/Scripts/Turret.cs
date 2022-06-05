using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tryplane.Alexander
{
    public class Turret : MonoBehaviour
    {
        public GameObject target;
        public GameObject bulletPrefab;
        public Transform bulletSpawnTransform;

        public int ammo = 2;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (target == null)
            {
                return;
            }

            if (Vector3.Distance(target.transform.position, transform.position) < 500f)
            {
                if (ammo > 0)
                {
                    GameObject bullet = Instantiate(bulletPrefab, bulletSpawnTransform.position, bulletSpawnTransform.rotation);
                    bullet.GetComponent<HomingMissile>().target = target;
                    ammo--;
                }
            }
        }
    }
}