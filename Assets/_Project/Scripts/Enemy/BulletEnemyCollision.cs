using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyCollision : MonoBehaviour

{
    [SerializeField] private float _impactDistance = 1f; // Distancia hacia atr�s en el eje Y cuando es impactado

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Calcular la nueva posici�n del enemigo retrocediendo en el eje Y
            Vector3 impactPosition = other.transform.position - new Vector3(0f, 0f, _impactDistance);

            // Establecer la posici�n del enemigo
            other.transform.position = impactPosition;

            // Destruir la bala
            Destroy(gameObject);
        }
    }
}
