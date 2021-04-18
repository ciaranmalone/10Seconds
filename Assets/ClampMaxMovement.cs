using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampMaxMovement : MonoBehaviour
{
    [SerializeField] private float maxLeft, maxRight;
    void Update()
    {
        Vector3 pos = transform.localPosition;

        Debug.Log(pos);

        pos.x = Mathf.Clamp(pos.x, maxLeft, maxRight);
        transform.position = pos;
    }
}

