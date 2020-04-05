using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private Transform directionPoint;

    public void Shot(Rocket rocket)
    {

        var direction = (directionPoint.position - spawnPoint.position);
        var newRocket = Instantiate(rocket, spawnPoint.position, Quaternion.Euler(new Vector3(direction.x, direction.y, direction.z + 180)));
        gameObject.GetComponentInParent<Attractor>().exeptions.Add(newRocket.gameObject);
        Debug.DrawRay(spawnPoint.position, direction.normalized * newRocket.Force, Color.yellow);
        //newRocket.rb.AddForce(direction.normalized * newRocket.Force, ForceMode2D.Force);
        newRocket.rb.velocity = direction.normalized * newRocket.Force;
    }
}
