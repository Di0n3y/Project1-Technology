using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitPlayer : MonoBehaviour
{
    [SerializeField] private Transform _limitRight;
    [SerializeField] private Transform _limitLeft;

    void Start()
    {
        if (_limitRight == null || _limitLeft == null)
        {
            _limitRight = GameObject.FindWithTag("LimitRight").transform;
            _limitLeft = GameObject.FindWithTag("LimitLeft").transform;
        }


    }

    void LateUpdate()
    {
        float limitRight = _limitRight.position.z;
        float limitLeft = _limitLeft.position.z;
        float limitUp = _limitRight.position.y;
        float limitDown = _limitLeft.position.y;

        Vector3 position = transform.position;

        if (position.z > limitRight)
            position.z = limitRight;
        else if (position.z < limitLeft)    
            position.z = limitLeft;


        if (position.y > limitUp)
            position.y = limitUp;
        else if (position.y < limitDown)
            position.y = limitDown;

        transform.position = position;


    }

  
}
