using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public Transform firePoint2;
    public GameObject BulletPrefab;

    public float bulletForce = 20f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
        GameObject bullet2 = Instantiate(BulletPrefab, firePoint2.position, firePoint2.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        rb2.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
    }
}
