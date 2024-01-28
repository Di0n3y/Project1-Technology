using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private UnityEvent<Vector3> _onMove = new();
    [SerializeField] private UnityEvent _onFire = new();
    [SerializeField] private UnityEvent _Shield = new();
    

    void Update()
    {

        _onMove?.Invoke(new Vector3(0,0, Input.GetAxis("Vertical")));

        if (Input.GetButtonDown("Fire1"))
            _onFire?.Invoke();

        if (Input.GetKeyDown(KeyCode.E)) 
            _Shield?.Invoke();


    }
}