using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoSingleton<GameController>
{
    #region Fields
    [SerializeField]
    private PlanetSpawner planetSpawner;
    [SerializeField]
    private GameObject sunGO;
    [SerializeField]
    private int minEnemiesCount;
    [SerializeField]
    private int maxEnemiesCount;
    #endregion Fields

    #region Unity Methods
    private void Awake()
    {
        StartGame();
    }
    #endregion Unity Methods

    #region Methods
    public void StartGame()
    {
        var rnd = Random.Range(minEnemiesCount, maxEnemiesCount + 1);
        planetSpawner.SpawnPlanets(rnd);
    }
    #endregion Methods
}