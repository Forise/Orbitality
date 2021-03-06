﻿using UnityEngine;

public class GameDriver : MonoSingleton<GameDriver>
{
    [SerializeField]
    private GameController gamePrefab;
    [SerializeField]
    private GameObject mainUI;
    [SerializeField]
    private GameObject gameUI;

    private GameController currentGame;
    public GameController CurrentGame => currentGame;


    private void Start()
    {
        gameUI.gameObject.SetActive(false);
    }

    public void StartNewGame()
    {
        TimeScale.gameSclae = 1;
        if (mainUI != null)
        {
            mainUI.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("mainUI is null!", this);
        }
        if (gameUI != null)
        {
            gameUI.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("gameUI is null!", this);
        }
        if (gamePrefab != null)
        {
            var newGame = Instantiate(gamePrefab);
            currentGame = newGame;
        }
        else
        {
            Debug.LogError("GamePrefab is null!", this);
        }
    }

    public void RestartGame()
    {
        Destroy(currentGame.gameObject);
        StartNewGame();
    }

    public void EndCurrentGame()
    {
        Destroy(currentGame.gameObject);
        if (mainUI != null)
        {
            mainUI.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("mainUI is null!", this);
        }
        if (gameUI != null)
        {
            gameUI.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("gameUI is null!", this);
        }
    }
}