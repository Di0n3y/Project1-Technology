using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetEnemy : MonoBehaviour
{
    [SerializeField] private Transform _limitRight;
    [SerializeField] private Transform _limitLeft;
   
    
    private void Start()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
        if (_limitRight == null || _limitLeft == null)
        {
            _limitRight = GameObject.FindWithTag("LimitRight").transform;
            _limitLeft = GameObject.FindWithTag("LimitLeft").transform;
        }
    }

    public void EnemyReset()
    {
        float limitRight = _limitRight.position.z;
        float limitLeft = _limitLeft.position.z;
        float limitUp = _limitRight.position.y;
        
        Vector3 position = transform.position;
        
        float randomYPosition = Random.Range(limitLeft, limitRight);

        
        position.z = limitRight;
        position.y = randomYPosition;
        
        transform.position = position;
    }
}
