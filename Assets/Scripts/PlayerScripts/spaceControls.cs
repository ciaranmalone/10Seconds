using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceControls : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    private Vector3 direction;
    void Update()
    {
        direction = new Vector3(0,Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        transform.Translate(0,direction.y * Time.deltaTime * speed, direction.z * Time.deltaTime * speed);
    }
}

