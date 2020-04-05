using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour
{
    private float speed;
    [SerializeField]
    private float minSpeed = 0.1f;
    private float maxSpeed = 2f;
    public GameObject moveAroundObject;

    private void Awake()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    private void Move()
    {
        transform.RotateAround(moveAroundObject.transform.position, Vector3.forward, 20 * Time.deltaTime * speed);

        Vector3 dir = moveAroundObject.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void Update()
    {
        Move();
    }
}
