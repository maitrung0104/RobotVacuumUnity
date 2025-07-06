using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public TextMeshProUGUI starCountText;
    public TextMeshProUGUI winMessage;

    [Header("Game")]
    public int totalStars = 6;
    public int collectedStars = 0;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        // Ẩn win message
        winMessage.gameObject.SetActive(false);

        // Hiển thị số ngôi sao
        UpdateUI();
    }

    public void CollectStar()
    {
        collectedStars++;
        UpdateUI();

        // Kiểm tra thắng
        if (collectedStars >= totalStars)
        {
            winMessage.gameObject.SetActive(true);
            winMessage.text = "YOU WIN!";
        }
    }

    void UpdateUI()
    {
        starCountText.text = "Stars: " + collectedStars + "/" + totalStars;
    }
}