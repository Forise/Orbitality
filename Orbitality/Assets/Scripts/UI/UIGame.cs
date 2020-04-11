using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoSingleton<UIGame>
{
    public HealthBarUI healthBarUI;
    public Button pauseButton;

    private void Awake()
    {
        pauseButton.onClick.AddListener(()=> { UIController.Instance.OpenWindow("pause", this); });
    }
}
