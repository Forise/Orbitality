using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageComponent : MonoBehaviour
{
    public float damage;
    public GameObject exceptionGO;
    public GameObject ExceptionObject { get; set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != exceptionGO)
        {
            var health = collision.gameObject.GetComponent<HealthComponent>();
            if (health != null)
            {
                health.Health -= damage;
            }
        }
    }
}