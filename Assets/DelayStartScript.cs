using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayStartScript : MonoBehaviour
{
    [SerializeField] private float timeDelay = 1f;
    [SerializeField] private GameObject hiddenObject;

    void Awake()
    {
        StartCoroutine(Appear());
    }

    IEnumerator Appear()
    {
        hiddenObject.SetActive(false);
        yield return new WaitForSeconds(timeDelay);
        hiddenObject.SetActive(true);
    }
}