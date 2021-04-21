using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed = 20f;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, transform.up, speed * Time.deltaTime);
        transform.LookAt(target.transform.position);
    }
}
