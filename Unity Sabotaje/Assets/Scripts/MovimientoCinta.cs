using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCinta : MonoBehaviour
{
    public Transform cintaTransportadora;  // Referencia a la transformación de la cinta transportadora
    private Rigidbody rb;  // Referencia al componente Rigidbody de la esfera
    private float tiempoAcumulado;  // Tiempo acumulado para medir un segundo

    void Start()
    {
        // Obtén el componente Rigidbody de la esfera
        rb = GetComponent<Rigidbody>();
        tiempoAcumulado = 0f;  // Inicializa el tiempo acumulado a cero
    }

    void FixedUpdate()
    {
        // Calcula el vector de movimiento entre la posición actual de la esfera y la posición de la cinta transportadora
        Vector3 movement = cintaTransportadora.position - transform.position;

        // Mueve la esfera utilizando el componente Rigidbody
        rb.MovePosition(rb.position + movement);

        // Incrementa el tiempo acumulado con el tiempo transcurrido entre fotogramas
        tiempoAcumulado += Time.deltaTime;

        // Si ha transcurrido un segundo, reinicia el tiempo acumulado y mueve la cinta transportadora
        if (tiempoAcumulado >= 1f)
        {
            tiempoAcumulado = 0f;  // Reinicia el tiempo acumulado

            // Aquí puedes agregar la lógica para mover la cinta transportadora cada segundo
            // Por ejemplo, puedes cambiar la posición de la cinta o ajustar su velocidad
            // dependiendo de cómo quieras que funcione tu cinta transportadora.
        }
    }
}