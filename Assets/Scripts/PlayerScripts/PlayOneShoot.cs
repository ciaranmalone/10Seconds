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

    private void Update()
    {
        if (Input.GetKey(shoot) && coolDowned)
        {
            Instantiate(bullets, transform.position, transform.rotation);
            coolDowned = false;
        }

        if(!coolDowned && !coolDownStarted)
        {
            StartCoroutine(CoolDown());
        }
    }

    IEnumerator CoolDown()
    {
            coolDownStarted = true;
            yield return new WaitForSeconds(pauseTime);
            coolDowned = true;
            coolDownStarted = false;
    }
}
