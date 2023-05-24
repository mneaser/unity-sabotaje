using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMachine : MonoBehaviour
{
    public GameObject correctIndicator; // Indicador visual de entrada correcta
    public GameObject incorrectIndicator; // Indicador visual de entrada incorrecta
    public int maxIncorrectAttempts = 10; // Número máximo de intentos incorrectos antes de finalizar el juego

    private int incorrectAttempts; // Contador de intentos incorrectos
    private Color correctColor; // Color correcto de entrada

    private void Start()
    {
        // Establecer un color inicialmente
        correctColor = Color.blue; // Por ejemplo, azul

        // Actualizar los indicadores visuales según el color correcto
        correctIndicator.SetActive(true);
        incorrectIndicator.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto en la máquina es un objeto recogible
        MovableCollectableObject collectableObject = other.GetComponent<MovableCollectableObject>();
        if (collectableObject != null)
        
    
            {
                // Entrada correcta: realizar acciones
                Debug.Log("Entrada correcta");

                // Reiniciar el contador de intentos incorrectos
                incorrectAttempts = 0;
                correctIndicator.SetActive(true);
                incorrectIndicator.SetActive(false);
            }
            else
            {
                // Entrada incorrecta: aumentar el contador de intentos incorrectos
                incorrectAttempts++;

                // Verificar si se alcanzó el número máximo de intentos incorrectos
                if (incorrectAttempts >= maxIncorrectAttempts)
                {
                    // Se alcanzó el límite de intentos incorrectos: finalizar el juego
                    EndGame();
                }
                else
                {
                    // Actualizar los indicadores visuales según la entrada incorrecta
                    correctIndicator.SetActive(false);
                    incorrectIndicator.SetActive(true);
                }
            
        }
    }

    private void EndGame()
    {
        // Lógica para finalizar el juego debido a un número máximo de intentos incorrectos
        Debug.Log("Fin del juego");
        // Puedes mostrar una pantalla de fin de juego, reiniciar el nivel, etc.
    }
}
