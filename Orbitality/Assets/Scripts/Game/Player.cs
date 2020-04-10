﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Planet planet;
    private float shotDelay = 0f;
    private void Start()
    {
        planet = GetComponent<Planet>();
        shotDelay = planet.Rocket.ShootDelay;
    }

    private void Update()
    {
        shotDelay -= Time.deltaTime;
        if(Input.GetKey(KeyCode.Space) && shotDelay <= 0)
        {
            shotDelay = planet.Rocket.ShootDelay;
            planet.Gun.Shot(planet.Rocket);
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
