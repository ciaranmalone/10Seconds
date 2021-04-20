using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelfDestruct : MonoBehaviour
{
    [SerializeField] private float destructTime = 1f;
   
    void Start()
    {
        StartCoroutine(SelfDestructCall());
        //AudioSource playMe = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
        //if (explosiveNoise != null)
        //{
        //    playMe.clip = explosiveNoise;

        //}
        //else
        //{
        //    playMe.clip = Resources.Load<AudioClip>("Bass boosted Yoda death sound");
        //}
        //playMe.PlayOneShot(playMe.clip, 1); //Just play is deprecated
    }

    IEnumerator SelfDestructCall()
    {

        yield return new WaitForSeconds(destructTime);
        Destroy(gameObject);
    }
}
