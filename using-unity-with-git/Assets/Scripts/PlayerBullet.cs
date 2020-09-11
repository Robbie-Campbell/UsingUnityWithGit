using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBullet : MonoBehaviour
{

    public GameObject hitEffect;
    public AudioSource hitAudio;

    void start ()
    {
        hitAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            hitAudio.Play();
            Destroy(collision.gameObject, 0.2f);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.8f);
            ScoreScript.scoreValue += 1;
        }
    }
}
