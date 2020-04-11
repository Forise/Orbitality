using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Planet planet;
    private HealthComponent health;
    private float shotDelay = 0f;
    private void Start()
    {
        planet = gameObject.GetComponent<Planet>();
        health = gameObject.GetComponent<HealthComponent>();
        if (planet.Rocket != null)
        {
            shotDelay = planet.Rocket.ShootDelay;
        }
        if(health != null)
        {
            health.Died += () => { GameDriver.Instance.EndCurrentGame(); };
        }
    }

    private void Update()
    {
        shotDelay -= Time.deltaTime;
        if(Input.GetKey(KeyCode.Space) && shotDelay <= 0)
        {
            shotDelay = planet.Rocket.ShootDelay;
            planet.Gun.Shot(planet.Rocket, gameObject);
        }
        if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            planet.Gun.RotateLeft();
        }
        if(Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            planet.Gun.RotateRight();
        }
    }
}
