using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxSpin : MonoBehaviour
{
    [SerializeField] private Material obama;
    private float spin = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spin = spin + .1f;
        obama.SetFloat("_Rotation", spin);
    }
}
