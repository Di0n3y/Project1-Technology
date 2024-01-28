using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class AIHandler : MonoBehaviour
{

    [SerializeField] private UnityEvent<Vector3> _onMove = new();
    [SerializeField] private Vector3 _direction = default;


    void Update()
    {

        _onMove?.Invoke(_direction);

      
    }

        public void AvoidEnemy()
    {
        _direction.y = +1;




    }

}
