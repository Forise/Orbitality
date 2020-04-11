using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D)), RequireComponent(typeof(DamageComponent))]
public class Rocket : MonoBehaviour
{
    [SerializeField]
    private float mass;
    [SerializeField]
    private float force;
    [SerializeField]
    private float shootDelay;
    [SerializeField]
    private float autodestroyDelay = 10f;

    public DamageComponent damageComponent;    
    public Rigidbody2D rb;

    public float Force => force;
    public float ShootDelay => shootDelay;

    private void Awake()
    {
        if(rb == null)
        {
            rb = gameObject.GetComponent<Rigidbody2D>();
        }
        if(damageComponent == null)
        {
            damageComponent = gameObject.GetComponent<DamageComponent>();
        }
        rb.mass = mass;
        Destroy(gameObject, autodestroyDelay);
    }
}
