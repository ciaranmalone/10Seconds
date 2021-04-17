using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndShoot : MonoBehaviour
{
    [SerializeField] private KeyCode left;
    [SerializeField] private KeyCode right;
    [SerializeField] private KeyCode shoot;
    [SerializeField] private GameObject bullets;

    void Update()
    {
        if(Input.GetKey(left))
        {
            transform.Rotate(0, 0, -1);
        } 
        else if(Input.GetKey(right))
        {
            transform.Rotate(0, 0, 1);

        }

        if (Input.GetKey(shoot))
        {
            GameObject shot = Instantiate(bullets, transform.position, transform.rotation);

        }
    }
}