using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedController : MonoBehaviour
{
    [Header("References")]
    public RobotVacuum2D robot;
    public Slider speedSlider;
    public TextMeshProUGUI speedText;

    void Start()
    {
        // Setup slider
        speedSlider.minValue = 1f;
        speedSlider.maxValue = 8f;
        speedSlider.value = robot.moveSpeed;

        // Lắng nghe sự kiện thay đổi slider
        speedSlider.onValueChanged.AddListener(OnSpeedChanged);

        UpdateSpeedText();
    }

    void OnSpeedChanged(float value)
    {
        robot.SetSpeed(value);
        UpdateSpeedText();
    }

    void UpdateSpeedText()
    {
        speedText.text = "Speed: " + speedSlider.value.ToString("F1");
    }
}