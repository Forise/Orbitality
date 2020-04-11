using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseWindow : UIWindow
{
    [SerializeField]
    private Button resumeGameButton;
    [SerializeField]
    private Button startNewGameButton;
    [SerializeField]
    private Button exitButton;

    private void OnEnable()
    {
        resumeGameButton.onClick.AddListener(OnResumeGameButtonPressed);
        startNewGameButton.onClick.AddListener(OnStartNewGameButtonPressed);
        exitButton.onClick.AddListener(OnExitButtonPressed);
    }

    private void OnDisable()
    {
        resumeGameButton.onClick.RemoveListener(OnResumeGameButtonPressed);
        startNewGameButton.onClick.RemoveListener(OnStartNewGameButtonPressed);
        exitButton.onClick.RemoveListener(OnExitButtonPressed);
    }

    protected override void OpenAnimationStateInitHandler()
    {
        base.OpenAnimationStateInitHandler();
        //TODO: Set game TimeScale to 0;
    }

    #region Handlers
    private void OnResumeGameButtonPressed()
    {
        //TODO: Set game TimeScale to 1;
        CloseThisWindow();
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
