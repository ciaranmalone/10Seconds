using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveInDirection : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    [SerializeField] private Vector3 moveDirection = new Vector3(0, 1, 0);
    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * Time.deltaTime * speed);

    }
}
