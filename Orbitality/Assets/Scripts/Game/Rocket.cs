using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
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
    
    public Rigidbody2D rb;
    public float Force => force;
    public float ShootDelay => shootDelay;

    private void Awake()
    {
        if(rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
        rb.mass = mass;
        Destroy(gameObject, autodestroyDelay);
    }
}
