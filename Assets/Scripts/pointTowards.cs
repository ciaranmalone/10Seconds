using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointTowards : MonoBehaviour
{
    [SerializeField] private GameObject target;

    void Update()
    {
        transform.LookAt(target.transform.position);
    }
}
