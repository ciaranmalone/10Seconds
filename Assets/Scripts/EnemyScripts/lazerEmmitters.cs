using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazerEmmitters : MonoBehaviour
{
    [SerializeField] private GameObject LaserPrefab;
    [SerializeField] private float TimeDelay;

    private void Start()
    {
        InvokeRepeating("ShootLaser", 0.4f, TimeDelay);
    }
    void ShootLaser()
    {
        Instantiate(LaserPrefab, transform.position, transform.rotation);
    }
}