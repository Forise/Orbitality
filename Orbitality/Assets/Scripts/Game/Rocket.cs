using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D)), RequireComponent(typeof(DamageComponent))]
public class Rocket : MonoBehaviour
{
    private Vector3 lastPos;
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
        lastPos = transform.position;
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

    
    private void Update()
    {
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - 90);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<RocketDestroyer>() != null)
        {
            Destroy(gameObject, .01f);
        }
    }
}
