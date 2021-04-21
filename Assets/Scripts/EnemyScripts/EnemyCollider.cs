using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    [SerializeField] int health = 1;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Color32 color;
    [SerializeField] private bool deleteBullet = false;
    [SerializeField] private GameObject explosion;
    [SerializeField] private AudioClip painSound;
    private void Start()
    {

        if (spriteRenderer == null)
        {
            Debug.Log("ssdasd");
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("been hits");
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            if (deleteBullet) Destroy(collision.gameObject);

            StartCoroutine(flash());
            health--;
            AudioSource playMe = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
            if (painSound != null)
            {
                playMe.clip = painSound;
                playMe.PlayOneShot(playMe.clip, 1); //Just play is deprecated
            }
          
           
            if (health == 0)
            {
                death();
            }
        }
    }

    void death()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    IEnumerator flash()
    {
        spriteRenderer.color = color;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = new Color32(255, 255, 255, 255);
    }
}