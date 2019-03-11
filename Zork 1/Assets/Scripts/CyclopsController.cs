using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework.Constraints;
using UnityEngine;

public class CyclopsController : MonoBehaviour
{
     public float moveSpeed;

     private Rigidbody2D cyclopsRB2D;

     private bool isMoving;

     public float timeBetweenMove;

     private float timeBetweenMoveCounter;

     public float timeToMove;

     private float timeToMoveCounter;

     private Vector3 moveDirection;

     public Animator myCyclopsAnim;

     public float cyclopsHealth;

     public bool cyclopsDeath;

     // Start is called before the first frame update
     void Start()
     {
          cyclopsRB2D = GetComponent<Rigidbody2D>();
          cyclopsDeath = false;
          cyclopsHealth = 100;
          //timeBetweenMoveCounter = timeToMove;
          //timeToMoveCounter = timeToMove;

          timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.25f, timeBetweenMove * 1.75f);
          timeToMoveCounter = Random.Range(timeToMove * .025f, timeToMove * 1.75f);
          myCyclopsAnim.SetBool("cyclopsDeath", false);

     }

     // Update is called once per frame
     void Update()
     {
          if (isMoving)
          {
               timeToMoveCounter -= Time.deltaTime;
               cyclopsRB2D.velocity = moveDirection;
               myCyclopsAnim.SetFloat("moveX", cyclopsRB2D.velocity.x);
               myCyclopsAnim.SetFloat("moveY", cyclopsRB2D.velocity.y);
               myCyclopsAnim.SetFloat("lastMoveX", cyclopsRB2D.velocity.x);
               myCyclopsAnim.SetFloat("lastMoveY", cyclopsRB2D.velocity.y);
               if (cyclopsHealth <= 0f)
               {
                    isMoving = false;
                    myCyclopsAnim.SetBool("cyclopsDeath", true);
               }
               else if (timeToMoveCounter < 0f)
               {
                    isMoving = false;
                    timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.25f, timeBetweenMove * 1.75f);

               }
          }
          else
          {
               timeBetweenMoveCounter -= Time.deltaTime;
               cyclopsRB2D.velocity = Vector2.zero;
               myCyclopsAnim.SetFloat("moveX", cyclopsRB2D.velocity.x);
               myCyclopsAnim.SetFloat("moveY", cyclopsRB2D.velocity.y);
               if (cyclopsHealth <= 0f)
               {
                    isMoving = false;
                    myCyclopsAnim.SetBool("cyclopsDeath", true);
               }
               else if (timeBetweenMoveCounter < 0f && cyclopsDeath == false)
               {
                    isMoving = true;
                    timeToMoveCounter = Random.Range(timeToMove * .025f, timeToMove * 1.75f);

                    moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed,
                        0f);
                    myCyclopsAnim.SetFloat("moveX", cyclopsRB2D.velocity.x);
                    myCyclopsAnim.SetFloat("moveY", cyclopsRB2D.velocity.y);
               }
          }
     }

     public void setHealth(int damage)
     {
          cyclopsHealth -= damage;
          if (cyclopsHealth <= 0f)
          {
               cyclopsDeath = true;
               cyclopsHealth = -500;
               isMoving = false;
               myCyclopsAnim.SetBool("cyclopsDeath", true);
          }
     }
}
