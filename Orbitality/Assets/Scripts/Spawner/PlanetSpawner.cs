using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    [SerializeField]
    private List<Transform> pointsToSpawn = new List<Transform>();
    [SerializeField]
    private List<Planet> prefabsPool = new List<Planet>();
    [SerializeField]
    private List<Rocket> rockets = new List<Rocket>();
    private List<Planet> spawnedPlanets = new List<Planet>();
    [SerializeField]
    private Planet playerPrefab;
    [SerializeField]
    private GameObject sunGO;

    public void SpawnPlanets(int count)
    {
        var pointsForSpawn = pointsToSpawn;
        var prefabs = prefabsPool;
        int rndPoint = Random.Range(0, pointsForSpawn.Count);
        var player = Instantiate(playerPrefab, pointsForSpawn[rndPoint]);
        var playerHealth = player.gameObject.GetComponent<HealthComponent>();
        if(playerHealth != null)
        {
            playerHealth.healthBar = UIGame.Instance.healthBarUI;
            playerHealth.Resetup();
        }
        player.Setup(sunGO, rockets[Random.Range(0, rockets.Count)]);
        spawnedPlanets.Add(player);
        pointsForSpawn.RemoveAt(rndPoint);
        for (int i = 0; i < count && i < pointsForSpawn.Count && i < prefabs.Count; i++)
        {
            rndPoint = Random.Range(0, pointsForSpawn.Count);
            int rndPrefab = Random.Range(0, prefabs.Count);
            var newPlanet = Instantiate(prefabs[rndPrefab], pointsForSpawn[rndPoint]);
            newPlanet.Setup(sunGO, rockets[Random.Range(0, rockets.Count)]);
            spawnedPlanets.Add(newPlanet);
            pointsForSpawn.RemoveAt(rndPoint);
            prefabs.RemoveAt(rndPrefab);
        }
    }
}