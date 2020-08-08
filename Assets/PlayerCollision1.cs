using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision1 : MonoBehaviour
{
    public PlayerMovement1 movement;
    public Rigidbody rb;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Endpoint")
        {

            rb.AddForce(0,-10000f,0); ;

        }
    }
}
