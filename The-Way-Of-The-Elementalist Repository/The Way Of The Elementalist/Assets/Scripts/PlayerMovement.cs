using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Public Variables
    public float forceStrengh;

    public void Jump()
    {

    }
    public void MoveRight()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.AddForce(Vector2.right * forceStrengh);
    }
    public void MoveLeft()
    {
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.AddForce(Vector2.left * forceStrengh);
    }

}