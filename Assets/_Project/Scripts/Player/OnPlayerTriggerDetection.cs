using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnPlayerTriggerDetection : MonoBehaviour
{
    [SerializeField] private UnityEvent _onEnemyDetected = new();
    [SerializeField] private UnityEvent<int> _onBulletDamage = new();
    private void OnTriggerEnter(Collider other)
    {

        switch (other.tag)
        {
            case "Enemy":
                _onEnemyDetected?.Invoke();
                break;
            case "BulletEnemy":
                _onBulletDamage?.Invoke(other.GetComponent<BulletData>().Damage);
                break;
        }
    }
}
