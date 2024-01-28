using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LimitEnemy : MonoBehaviour
{

    [SerializeField] private Transform _limitRight;
    [SerializeField] private Transform _limitLeft;

    void Start()
    {
        
        Random.InitState((int)System.DateTime.Now.Ticks);
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
        float randomY = Random.Range(limitLeft, limitRight);


        

        if (position.y > limitUp)
            position.y = position.y = limitDown;
        else if (position.y < limitDown)
            position.y = position.y = limitUp;
      
        
       if (position.z > limitRight)
            position.z = position.z = limitRight;
        else if (position.z < limitLeft)
        {
            position.z = position.z = limitRight;
            position.y = randomY;

        }

            transform.position = position;
    }
}
