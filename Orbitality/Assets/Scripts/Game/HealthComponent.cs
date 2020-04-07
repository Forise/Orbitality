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
    [SerializeField]
    private HealthBarUI healthBar;

    public float Health
    {
        get => currentHealth;
        set
        {
            currentHealth = value;
            if(healthBar)
                healthBar.Value = value;
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
        if (healthBar)
        {
            healthBar.Setup(maxHealth, 0);
            healthBar.Value = currentHealth;
        }
    }
}