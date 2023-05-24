using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCintaTransportadora : MonoBehaviour
{
    private GameObject personajePrincipal;
    private bool objetoSostenido;

    void Start()
    {
        personajePrincipal = GameObject.FindGameObjectWithTag("PersonajePrincipal");
    }

    void Update()
    {
        // Verificar si el botón de agarre está presionado
        if (Input.GetButtonDown("Agarre") && !objetoSostenido)
        {
            // Calcular la distancia entre el personaje principal y el objeto
            float distancia = Vector3.Distance(transform.position, personajePrincipal.transform.position);

            // Verificar si el personaje principal está lo suficientemente cerca del objeto
            if (distancia <= 2f)
            {
                // Sostener el objeto
                objetoSostenido = true;

                // Hacer que el objeto sea un hijo del personaje principal
                transform.parent = personajePrincipal.transform;
            }
        }
        // Verificar si se suelta el botón de agarre
        else if (Input.GetButtonUp("Agarre") && objetoSostenido)
        {
            // Dejar de sostener el objeto
            objetoSostenido = false;

            // Desvincular el objeto del personaje principal
            transform.parent = null;
        }
    }
}
