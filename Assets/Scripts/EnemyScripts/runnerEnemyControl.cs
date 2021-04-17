using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runnerEnemyControl : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    private Vector3 moveDirection = new Vector3(0, 0, -1);

    void Update()
    {
        transform.Translate(moveDirection * Time.deltaTime * speed);
    }

}
