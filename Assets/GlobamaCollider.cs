using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobamaCollider : MonoBehaviour
{
    [SerializeField] int health = 100;

    [SerializeField] private GameObject explosion;
    [SerializeField] private AudioClip painSound;
    AudioSource playMe;
    // Start is called before the first frame update
    void Start()
    {
        playMe = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("been hits");
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(collision.gameObject);

            Instantiate(explosion, transform.position, transform.rotation);
            health--;
            if (painSound != null)
            {
                playMe.clip = painSound;
                playMe.PlayOneShot(playMe.clip, 1);
            }

            if (health == 0)
            {
                death();
            }
        }
    }
    void death()
    {
        Destroy(gameObject);
    }
}