using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftAndRight : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    [SerializeField] private Vector3 moveDirection = new Vector3(2, 0, 0);

    private void Start()
    {
        InvokeRepeating("moveLeft", 0.4f, .3f);

    }
    private void Update()
    {
        transform.Translate(moveDirection * Time.deltaTime * speed);
    }

    void moveLeft()
    {
        if (Random.value < .5)
            speed = 5;
         else
            speed = -5;
    }
}