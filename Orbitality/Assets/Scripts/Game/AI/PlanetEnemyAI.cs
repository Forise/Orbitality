using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetEnemyAI : MonoBehaviour
{
    [SerializeField]
    private TargerDetecter detecter;
    [SerializeField]
    private Planet planet;
    private float shotDelay = 0;

    private void Update()
    {
        shotDelay -= Time.deltaTime;
        GameObject targetGO = detecter.GetObject();
        if (targetGO != null)
        {
            Transform targetTransform = targetGO.transform;
            planet.Gun.RotateTo(targetTransform);
            
            if (shotDelay <= 0)
            {
                shotDelay = planet.Rocket.ShootDelay;
                planet.Gun.Shot(planet.Rocket, gameObject);
            }
        }
    }
}