using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    //public AudioSource playerActionssnd;
    //public AudioClip shoot;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            //playerActionssnd.PlayOneShot(shoot);
        }
    }

    void Shoot()
    {
        //shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
