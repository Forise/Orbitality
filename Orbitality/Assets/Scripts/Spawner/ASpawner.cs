using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ASpawner<T> : MonoBehaviour where T : MonoBehaviour
{
    public T Spawn(T go, Transform transform)
    {
        return Instantiate(go, transform);
    }
}
