using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private List<ISavable> savables;
    public string Path { get; private set; } = Application.persistentDataPath + "save.json";

    private void Register(ISavable savable)
    {
        savables.Add(savable);
    }

    private void Unregister(ISavable savable)
    {
        savables.Remove(savable);
    }

    public void SaveLocal()
    {

    }
}