using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampMaxMovement : MonoBehaviour
{
    [SerializeField] private float maxLeft, maxRight, maxDown, maxUp;
    void Update()
    {
        Vector3 pos = transform.localPosition;
        Debug.Log(pos);
        pos.x = Mathf.Clamp(pos.x, maxLeft, maxRight);
        pos.y = Mathf.Clamp(pos.y, maxDown, maxUp);
        transform.localPosition = pos;
    }
}