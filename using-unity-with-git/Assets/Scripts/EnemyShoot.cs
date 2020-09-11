using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;
    public AudioSource shootAudio;
    public int interval = 5;
    float nextTime = -1;

    public float bulletForce = 5f;

    void start()
    {
        shootAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Time.time >= nextTime)
        {

            //do something here every interval seconds
            Shoot();
            nextTime += interval;

        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        shootAudio.Play();
    }
}
