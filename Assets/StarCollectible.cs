using UnityEngine;

public class StarCollectible : MonoBehaviour
{
    // Khi Robot chạm vào ngôi sao
    void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra có phải Robot không
        if (other.CompareTag("Robot"))
        {
            // Ẩn ngôi sao
            gameObject.SetActive(false);

            // Thông báo đã thu thập
            Debug.Log("Thu thập được ngôi sao!");

            // Gọi GameManager để đếm
            if (GameManager.Instance != null)
            {
                GameManager.Instance.CollectStar();
            }
        }
    }
}