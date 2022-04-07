using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

/// <summary>
/// Custom Animations
/// </summary>
public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Sprite[] animSprites;

    public float timeTreshold = 0.1f;
    private float timer;
    private int state = 0;

    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Time.time > timer)
        {
            sr.sprite = animSprites[state % animSprites.Length];
            state++;
            timer = Time.time + timeTreshold;
        }
    }
}