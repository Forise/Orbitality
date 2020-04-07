using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Slider))]
public class HealthBarUI : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Slider slider;

    private void Awake()
    {
        if(slider == null)
        {
            slider = gameObject.GetComponent<UnityEngine.UI.Slider>();
        }
    }

    public float Value
    {
        set => slider.value = value;
    }

    public void Setup(float max, float min)
    {
        slider.maxValue = max;
        slider.minValue = min;
    }
}
