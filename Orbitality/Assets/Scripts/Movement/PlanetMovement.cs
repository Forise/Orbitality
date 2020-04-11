using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour
{
    #region Fields
    private float movementSpeed;
    private float rotationSpeed;
    [SerializeField]
    private float minSpeed = 0.1f;
    private float maxSpeed = 2f;
    public GameObject moveAroundObject;
    #endregion Fields

    #region Unity Methods
    private void Awake()
    {
        var rndSpeed = Random.Range(minSpeed, maxSpeed);
        movementSpeed = rndSpeed;
        rotationSpeed = rndSpeed;
    }

    private void Update()
    {
        MoveAroundTarget();
    }
    #endregion Unity Methods

    #region Methods
    private void MoveAroundTarget()
    {
        if (moveAroundObject != null)
        {
            transform.RotateAround(moveAroundObject.transform.position, Vector3.forward, 20 * Time.deltaTime * movementSpeed * TimeScale.gameSclae);
            transform.rotation = Quaternion.identity;
        }
    }
    #endregion Methods
}
