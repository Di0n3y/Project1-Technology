using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnPlayerTriggerDetection : MonoBehaviour
{
    [SerializeField] private UnityEvent _onPlayerDetected = new();
    private void OnTriggerEnter(Collider other)
    {

        switch (other.tag)
        {
            case "Enemy":
                _onPlayerDetected?.Invoke();
                break;
        }
    }
}
