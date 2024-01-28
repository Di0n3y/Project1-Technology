using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnEnemyTriggerDetection : MonoBehaviour
{
    [SerializeField]private UnityEvent _onPlayerDetected = new();
    private void OnTriggerEnter(Collider other)
    {
        
        switch (other.tag)
        {
            case "Player":
                _onPlayerDetected?.Invoke();
                break;
        }
    }
   
}
