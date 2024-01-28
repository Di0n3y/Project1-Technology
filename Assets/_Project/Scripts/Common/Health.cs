using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
  [SerializeField] private int _maxHp = 3;
  [SerializeField] private UnityEvent _onDie = new();
  private int _currentHp = default;

  private void Start()
  {
    _currentHp = _maxHp;
  }

  public void CollisionDamage()
  {
    DoDamage(1);
  }

  public void DoDamage(int val)
  {
    _currentHp -= Mathf.Abs(val);
    if (_currentHp <= 0)
    {
      _onDie?.Invoke();
      _currentHp = _maxHp;
    }
  }
  
}
