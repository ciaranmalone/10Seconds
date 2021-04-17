using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Transform Camera;

    private void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    void Update()
    {
        transform.LookAt(Camera.position);
    }
}
