using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float _speed = 1f;
  
   public void Move (Vector3 input)
    {

        transform.Translate(0, input.z * Time.deltaTime * _speed, input.y * Time.deltaTime * _speed);

    }
}
