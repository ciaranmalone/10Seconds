using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeEvent : MonoBehaviour
{
    [SerializeField] private float time = 6f;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(getHit());
    }
    IEnumerator getHit()
    {
        yield return new WaitForSeconds(time);
        animator.Play("CamerafallAnim");
    }
}
