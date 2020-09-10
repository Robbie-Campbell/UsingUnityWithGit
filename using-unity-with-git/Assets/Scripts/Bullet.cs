using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{

    public GameObject hitEffect;
    public AudioSource hitAudio;

    void start ()
    {
        hitAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        hitAudio.Play();
        ScoreScript.scoreValue += 1;
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.8f);
    }
}
