﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlanetMovement)), RequireComponent(typeof(Gun))]
public class Planet : MonoBehaviour
{
    #region Fields
    [SerializeField]
    private float weight;
    [SerializeField]
    private PlanetMovement planetMovement;
    [SerializeField]
    private Gun gun;
    [SerializeField]
    private Rocket rocket;
    [SerializeField]
    private float minSize = 0.5f;
    [SerializeField]
    private float maxSize = 2f;
    #endregion Fields

    #region Properties
    public Gun Gun => gun;
    public Rocket Rocket => rocket;
    #endregion Properties

    #region Unity Methods
    private void Awake()
    {
        var size = Random.Range(minSize, maxSize);
        transform.localScale *= size;
        GetComponent<Rigidbody2D>().mass = size;
        planetMovement = planetMovement ?? GetComponent<PlanetMovement>();
    }

    #endregion Unity Methods
    public void Setup(GameObject sun, Rocket rocket)
    {
        planetMovement.moveAroundObject = sun;
        this.rocket = rocket;
    }
}
