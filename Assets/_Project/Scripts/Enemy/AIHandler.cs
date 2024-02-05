using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class AIHandler : MonoBehaviour
{

    [SerializeField] private UnityEvent<Vector3> _onMove = new();
    [SerializeField] private UnityEvent _onFire = new(); 
    [SerializeField] private Vector3 _direction = default;
    [SerializeField] private float _fireCooldown = 2f; 
    private float _currentFireCooldown = 0f;

    void Update()
    {
       
        _onMove?.Invoke(_direction);

     
        if (_currentFireCooldown <= 0f)
        {
            _onFire?.Invoke(); 
            _currentFireCooldown = _fireCooldown;
        }
        else
        {
            _currentFireCooldown -= Time.deltaTime; 
        }
    }

}
