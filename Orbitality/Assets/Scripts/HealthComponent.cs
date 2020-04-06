using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public event System.Action Died;
    [SerializeField]
    private float maxHealth;
    [SerializeField]
    private float currentHealth;

    public float Health
    {
        get => currentHealth;
        set
        {
            currentHealth = value;
            if(currentHealth <= 0)
            {
                Died?.Invoke();
                Destroy(gameObject);
            }
        }
    }

    public void Resetup()
    {
        currentHealth = maxHealth;
    }
}