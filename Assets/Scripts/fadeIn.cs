using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeIn : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private float appas = 0;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(255, 255, 255, appas);
        InvokeRepeating("fadeInSprite", 6, 0.5f);
    }

    private void fadeInSprite()
    {
        Debug.Log(appas);
        appas = appas + 0.1f;
        spriteRenderer.color = new Color(255, 255, 255, appas);
    }
}