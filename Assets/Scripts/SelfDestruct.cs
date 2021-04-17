using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField] private float destructTime = 1f;
    void Start()
    {
        StartCoroutine(SelfDestructCall());

    }

    IEnumerator SelfDestructCall()
    {
        yield return new WaitForSeconds(destructTime);
        Destroy(gameObject);
    }
}
