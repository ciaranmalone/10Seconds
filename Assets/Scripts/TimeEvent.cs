using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeEvent : MonoBehaviour
{
    [SerializeField] private float time = 6f;
    private AudioSource audioSource;
    private Animator animator;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        StartCoroutine(getHit());
    }
    IEnumerator getHit()
    {
        yield return new WaitForSeconds(time);
        animator.Play("CamerafallAnim");
        audioSource.Play();
    }
}
