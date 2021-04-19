using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceGhost : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    [SerializeField] private float yIncrease = -1;
  

    void Update()
    {
     Vector3 moveDirection = new Vector3(0, yIncrease, -1);
    transform.Translate(moveDirection.z * Time.deltaTime * speed, moveDirection.y * Time.deltaTime * speed / 2,0);
    }
}
