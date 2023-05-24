using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableCollectableObject : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 conveyorBeltDirection;

    private bool isBeingCarried; // Indica si el objeto está siendo transportado por el personaje

    private void Awake() //método para que algo se inicie
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetConveyorBeltDirection(Vector3 direction)
    {
        // Establece la dirección de la cinta transportadora para el objeto
        conveyorBeltDirection = direction;
    }

    public void MoveForward(float speed)
    {
       {
        // Mueve el objeto hacia adelante en la dirección y velocidad especificadas
        transform.Translate(Vector3.forward * speed);
    }  // Mueve el objeto hacia adelante en la dirección de la cinta transportadora si no está siendo transportado por el personaje
        if (!isBeingCarried)
        {
            rb.MovePosition(transform.position + conveyorBeltDirection * speed);
        }
    }

    public void SetCarriedState(bool carried)
    {
        // Establece el estado de transporte del objeto
        isBeingCarried = carried;
    }
}
