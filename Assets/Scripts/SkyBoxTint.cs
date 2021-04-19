using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxTint : MonoBehaviour
{
    [SerializeField] private Material obama;
    private float tint = 0.95f;

    private void Awake()
    {
        obama.SetFloat("_AtmosphereThickness", tint);
        obama.SetFloat("_Exposure", tint);
        InvokeRepeating("changeTint", 5f, 0.1f);
    }

    void changeTint()
    {
        tint = tint + .1f;
        obama.SetFloat("_AtmosphereThickness", tint);
        obama.SetFloat("_Exposure", tint);

    }
}
