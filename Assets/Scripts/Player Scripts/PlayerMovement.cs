using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// C# Script for player movements
/// </summary>
/// 
public class PlayerMovement : MonoBehaviour
{
     public float movementSpeed = 3f;

     private Rigidbody2D myBody;

     private Vector2 moveVector;
     
     private SpriteRenderer sr;

     private void Awake()
     {    //get the rigidbody2d component
          myBody = GetComponent<Rigidbody2D>();
          sr = GetComponent<SpriteRenderer>();
     }
          
     }

     private void OnEnable()
     {
          
     }

     private void Start()
     {
          
     }
}




























