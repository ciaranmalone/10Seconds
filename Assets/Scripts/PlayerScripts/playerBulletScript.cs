using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletScript : MonoBehaviour
{
    [SerializeField] private int speed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);

    }
}