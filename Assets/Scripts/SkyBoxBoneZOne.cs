using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxBoneZOne : MonoBehaviour
{
    [SerializeField] private Material obama;
    private float tint = 0f;

    void Start()
    {
        obama.SetFloat("_AtmosphereThickness", tint);
        InvokeRepeating("changeTint", 3f, 0.1f);

    }
    void changeTint()
    {
        tint = tint + .1f;
        obama.SetFloat("_AtmosphereThickness", tint);
    }
}
