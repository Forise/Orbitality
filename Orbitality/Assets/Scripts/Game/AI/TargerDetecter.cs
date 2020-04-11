using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class TargerDetecter : MonoBehaviour
{
    #region Fiedls
    [SerializeField]
    private Collider2D col;
    [SerializeField]
    private string tagToDetect;
    [SerializeField]
    private bool detectOnlyEnabledObjects;

    private List<GameObject> detectedObjects = new List<GameObject>();
    #endregion Fiedls

    #region Unity Methods
    private void Awake()
    {
        if (col == null)
        {
            col = GetComponent<Collider2D>();
        }
        col.isTrigger = true;
    }

    private void Update()
    {
        if (detectOnlyEnabledObjects)
        {
            foreach (var o in detectedObjects)
            {
                if (!o.activeInHierarchy)
                {
                    detectedObjects.Remove(o);
                    break;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision && (string.IsNullOrEmpty(tagToDetect) || collision.gameObject.tag == tagToDetect))
        {
            detectedObjects.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision)
        {
            detectedObjects.Remove(collision.gameObject);
        }
    }
    #endregion Unity Methods

    #region Methods
    public GameObject GetObject()
    {
        if (detectedObjects.Count > 0)
        {
            return detectedObjects[detectedObjects.Count - 1];
        }
        else
        {
            return null;
        }
    }
    #endregion Methods
}