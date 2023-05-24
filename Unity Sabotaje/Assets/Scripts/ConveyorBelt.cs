using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed = 1f; // Velocidad de la cinta transportadora

    private void OnTriggerStay(Collider other)
    {
        // Verifica si el objeto en la cinta transportadora es un objeto movible
        MovableCollectableObject movableObject = other.GetComponent<MovableCollectableObject>();
        if (movableObject != null)
        {
            // Mueve el objeto hacia adelante en la dirección de la cinta transportadora
            movableObject.MoveForward(speed * Time.deltaTime);

            // Mueve la cinta transportadora en el eje X
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
