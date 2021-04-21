using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCanvas : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    private Vector2 direction;

    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
