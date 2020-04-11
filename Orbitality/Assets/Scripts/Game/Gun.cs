using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    #region Fields
    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private Transform directionPoint;
    
    public float rotationSpeed = 1f;
    #endregion Fields

    #region Methods
    public void Shot(Rocket rocket, GameObject exceptionGO = null)
    {
        var direction = (directionPoint.position - spawnPoint.position);
        var newRocket = Instantiate(rocket, spawnPoint.position, Quaternion.identity, GameDriver.Instance.CurrentGame.transform);
        gameObject.GetComponentInParent<Attractor>().exeptions.Add(newRocket.gameObject);
        newRocket.damageComponent.ExceptionObject = transform.parent.gameObject;
        newRocket.damageComponent.exceptionGO = exceptionGO;

#if UNITY_EDITOR
        Debug.DrawRay(spawnPoint.position, direction.normalized * newRocket.Force, Color.yellow);
#endif

        newRocket.rb.velocity = direction.normalized * newRocket.Force * TimeScale.gameSclae;
    }

    public void RotateLeft()
    {
        transform.RotateAround(transform.parent.position, Vector3.forward, 1f * rotationSpeed * TimeScale.gameSclae);
    }
    public void RotateRight()
    {
        transform.RotateAround(transform.parent.position, Vector3.forward, -1f * rotationSpeed * TimeScale.gameSclae);
    }

    public void RotateTo(Transform target)
    {
        Vector3 dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg * TimeScale.gameSclae;
        transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward * TimeScale.gameSclae);

        transform.localPosition = dir.normalized;
    }
    #endregion Methods
}
