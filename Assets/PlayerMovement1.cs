using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewardForce = 500f;
    public Vector3 rotationForce;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {




        transform.Rotate(rotationForce);
        if (Input.GetKey("right"))
        {
            rb.AddForce(Time.deltaTime * sidewardForce, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(Time.deltaTime * -sidewardForce, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("up"))
        {
            rb.AddForce(0, 0, Time.deltaTime * forwardForce, ForceMode.VelocityChange);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, Time.deltaTime * -forwardForce, ForceMode.VelocityChange);
        }

        if (rb.position.y < -6f  )
        {
            FindObjectOfType<GameManager1>().CollisionOccur();
            FindObjectOfType<GameManager1>().EndGame();
        }
        void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionInfo.collider.tag == "Endpoint")
            {
                rb.useGravity = false;

            }
        }
    }
}
