using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainWindow : UIWindow
{
    [SerializeField]
    private Button startNewGameButton;
    [SerializeField]
    private Button loadGameButton;
    [SerializeField]
    private Button exitButton;

    private void OnEnable()
    {
        startNewGameButton.onClick.AddListener(OnStartNewGameButtonPressed);
        exitButton.onClick.AddListener(OnExitButtonPressed);
    }

    private void OnDisable()
    {
        startNewGameButton.onClick.RemoveListener(OnStartNewGameButtonPressed);
        exitButton.onClick.RemoveListener(OnExitButtonPressed);
    }

    #region Handlers
    private void OnStartNewGameButtonPressed()
    {
        GameDriver.Instance.StartNewGame();
    }
    private void OnExitButtonPressed()
    {
        Application.Quit();
    }
    #endregion Handlers
}
