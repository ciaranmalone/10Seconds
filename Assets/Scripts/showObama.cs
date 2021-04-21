using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showObama : MonoBehaviour
{
    [SerializeField] private Material obama;
    private float tint = 1f;
    
    void Start()
    {
        obama.SetFloat("_Metallic", tint);
        obama.SetFloat("_GlossMapScale", tint);
        InvokeRepeating("changeTint", 2f, .3f);
    }

    void changeTint()
    {
        tint -= .1f;
        obama.SetFloat("_Metallic", tint);
        obama.SetFloat("_GlossMapScale", tint);

    }
}
