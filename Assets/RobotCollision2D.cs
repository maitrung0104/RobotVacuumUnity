using UnityEngine;

public class RobotCollision2D : MonoBehaviour
{
    private RobotVacuum2D robotController;

    void Start()
    {
        robotController = GetComponent<RobotVacuum2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Kiểm tra va chạm với furniture hoặc wall
        if (collision.gameObject.CompareTag("Furniture") ||
            collision.gameObject.CompareTag("Wall"))
        {
            robotController.ChangeDirection();

            // Debug để kiểm tra
            Debug.Log("Robot va chạm với: " + collision.gameObject.name);
        }
    }
}