using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazerEmmitters : MonoBehaviour
{
    [SerializeField] private GameObject LaserPrefab;
    [SerializeField] private float TimeDelay;

    private void Start()
    {
        InvokeRepeating("ShootLaser", 0.4f, 0.3f);
    }
    void ShootLaser()
    {
        Instantiate(LaserPrefab, transform.position, transform.rotation);
    }
}
