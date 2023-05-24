using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputMachine : MonoBehaviour
{
    public GameObject[] objectPrefabs; // Array de prefabs de objetos
    public Transform spawnPoint; // Punto de generación de objetos
    public float spawnInterval = 2f; // Intervalo de generación de objetos

    private float timer;

    private void Update()
    {
        // Contador para generar objetos a intervalos regulares
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    private void SpawnObject()
    {
        // Genera un objeto aleatorio del array de prefabs
        GameObject randomObjectPrefab = objectPrefabs[Random.Range(0, objectPrefabs.Length)];

        // Instancia el objeto en el punto de generación
        GameObject spawnedObject = Instantiate(randomObjectPrefab, spawnPoint.position, Quaternion.identity);

    
        // Asigna el objeto a la cinta transportadora
        MovableCollectableObject movableObject = spawnedObject.GetComponent<MovableCollectableObject>();
        if (movableObject != null)
        {
            movableObject.SetConveyorBeltDirection(transform.forward);
        }
    }
}
