using UnityEngine;

public class DustCollectible : MonoBehaviour
{
    // Khi Robot chạm vào
    void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra có phải Robot không
        if (other.CompareTag("Robot"))
        {
            // Ngôi sao biến mất
            gameObject.SetActive(false);

            // In ra console (có thể bỏ)
            Debug.Log("Đã hút bụi!");
        }
    }
}