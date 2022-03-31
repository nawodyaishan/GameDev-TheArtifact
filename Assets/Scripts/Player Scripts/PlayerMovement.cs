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

     private GameObject artifact;
     
     private SpriteRenderer sr;
     private float harvestTimer;
     private bool isHarvesting;
     
     private string MOVEMENT_AXIS_X = "Horizontal";
     private string MOVEMENT_AXIS_Y = "Vertical";
     

     private void Awake()
     {    //get the rigidbody2d component
          myBody = GetComponent<Rigidbody2D>();
          sr = GetComponent<SpriteRenderer>();
     }

     private void Update()
     {
          FlipSprite();
     }

     private void FixedUpdate()
     {
          if (isHarvesting)
               myBody.velocity = Vector2.zero;
          else
          {
               moveVector = new Vector2(Input.GetAxisRaw(MOVEMENT_AXIS_X), Input.GetAxisRaw(MOVEMENT_AXIS_Y));

               if (moveVector.sqrMagnitude > 1)
                    moveVector = moveVector.normalized;
               
               myBody.velocity = new Vector2(moveVector.x * movementSpeed, moveVector.y * movementSpeed);
               
          }
     }

     void FlipSprite()
     {
          if (Input.GetAxisRaw(MOVEMENT_AXIS_X) == 1)
          {
               sr.flipX = false;
          }
          else if (Input.GetAxisRaw(MOVEMENT_AXIS_X) == -1)
          {
               sr.flipX = true;
          }
          
     }
}
 



























