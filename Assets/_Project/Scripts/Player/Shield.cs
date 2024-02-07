using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private GameObject shieldObject; 
    [SerializeField] private float duration = 5f; 
    [SerializeField] private float cooldown = 10f; 
    private bool isShieldActive = false; 
    private float nextActivationTime = 0f; 

    void Start()
    {
       
        DeactivateShield();
    }

    void Update()
    {
        
        if (isShieldActive && Time.time >= nextActivationTime)
        {
            DeactivateShield();
        }
    }

    public void ActivateShield()
    {
       
        if (!isShieldActive && Time.time >= nextActivationTime)
        {
           
            shieldObject.SetActive(true);
            isShieldActive = true;
            nextActivationTime = Time.time + duration + cooldown; 
        }
    }

    private void DeactivateShield()
    {
       
        shieldObject.SetActive(false);
        isShieldActive = false;
    }

    public bool IsShieldActive()
    {
        return isShieldActive;
    }
}