using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingAlley : MonoBehaviour
{
    public float forwardForce;
    public float leftBarrier;
    public float rightBarrier;
    public float moveIncrement;
    public Rigidbody rigidBody;


    public void Bowl()
    {
        //Ejemplo
        if (rigidBody != null)
        {
            rigidBody.AddForce(transform.forward * forwardForce, ForceMode.Impulse);
        }
    }

    public void MoveLeft()
    {
        if (transform.position.x > leftBarrier)
        {
            transform.position += new Vector3(-moveIncrement, 0, 0);
        }
    }

    public void MoveRight()
    {
        if (transform.position.x < rightBarrier)
        {
            transform.position += new Vector3(moveIncrement, 0, 0);
        }
    }

}
