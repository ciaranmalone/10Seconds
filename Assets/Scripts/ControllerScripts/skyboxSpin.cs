using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxSpin : MonoBehaviour
{
    [SerializeField] private Material obama;
    [SerializeField] private float SpinSpeed = 0.01f;
    private float spin = 0;

    private void Start()
    {
        InvokeRepeating("spinBG", 0, SpinSpeed);

    }

    void spinBG()
    {
        spin += .1f;
        obama.SetFloat("_Rotation", spin);

    }
}
