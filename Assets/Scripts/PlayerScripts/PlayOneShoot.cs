using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOneShoot : MonoBehaviour
{
    [SerializeField] private KeyCode shoot;
    [SerializeField] private GameObject bullets;
    [SerializeField] private float pauseTime = 1f;
    private bool coolDowned = true;
    private bool coolDownStarted = false;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Color32 color;
    private Transform cameraTransform;

    private void Start()
    {
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKey(shoot) && coolDowned)
        {
            GameObject bullet = Instantiate(bullets, transform.position, transform.rotation);
            bullet.transform.parent = cameraTransform;
            coolDowned = false;
        }

        if(!coolDowned && !coolDownStarted)
        {
            StartCoroutine(CoolDown());
    };
        }

    IEnumerator CoolDown()
    {
            spriteRenderer.color = color; 
            coolDownStarted = true;
            yield return new WaitForSeconds(pauseTime);
            coolDowned = true;
            coolDownStarted = false;
            spriteRenderer.color = new Color32(255,255,255,255);

    }
}
