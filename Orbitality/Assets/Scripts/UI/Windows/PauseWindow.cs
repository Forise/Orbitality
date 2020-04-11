using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseWindow : UIWindow
{
    [SerializeField]
    private Button resumeGameButton;
    [SerializeField]
    private Button saveGameButton;
    [SerializeField]
    private Button startNewGameButton;
    [SerializeField]
    private Button exitButton;

    private void OnEnable()
    {
        resumeGameButton.onClick.AddListener(OnResumeGameButtonPressed);
        saveGameButton.onClick.AddListener(OnSaveGameButtonPressed);
        startNewGameButton.onClick.AddListener(OnStartNewGameButtonPressed);
        exitButton.onClick.AddListener(OnExitButtonPressed);
    }

    private void OnDisable()
    {
        resumeGameButton.onClick.RemoveListener(OnResumeGameButtonPressed);
        saveGameButton.onClick.RemoveListener(OnSaveGameButtonPressed);
        startNewGameButton.onClick.RemoveListener(OnStartNewGameButtonPressed);
        exitButton.onClick.RemoveListener(OnExitButtonPressed);
    }

    protected override void OpenAnimationStateInitHandler()
    {
        base.OpenAnimationStateInitHandler();
        TimeScale.gameSclae = 0;
    }

    #region Handlers
    private void OnResumeGameButtonPressed()
    {
        TimeScale.gameSclae = 1;
        CloseThisWindow();
    }
    private void OnSaveGameButtonPressed()
    {
        UIController.Instance.OpenWindow("apologise");
    }
    private void OnStartNewGameButtonPressed()
    {
        CloseThisWindow();
        GameDriver.Instance.RestartGame();
    }
    private void OnExitButtonPressed()
    {
        CloseThisWindow();
        GameDriver.Instance.EndCurrentGame();
    }
    #endregion Handlers
}
