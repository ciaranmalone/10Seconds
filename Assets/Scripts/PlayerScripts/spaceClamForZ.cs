using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceClamForZ : MonoBehaviour
{
    [SerializeField] private float maxLeft, maxRight, maxDown, maxUp;
    void Update()
    {
        Vector3 pos = transform.localPosition;

        pos.z = Mathf.Clamp(pos.z, maxLeft, maxRight);

        pos.y = Mathf.Clamp(pos.y, maxDown, maxUp);
        transform.position = pos;
    }
}
