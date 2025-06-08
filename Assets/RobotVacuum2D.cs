using UnityEngine;

public class RobotVacuum2D : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 3f;

    private Vector2 moveDirection;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Bắt đầu di chuyển theo hướng ngẫu nhiên
        float randomAngle = Random.Range(0f, 360f);
        transform.rotation = Quaternion.Euler(0, 0, randomAngle);
        moveDirection = transform.up;
    }

    void FixedUpdate()
    {
        // Di chuyển robot
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    public void ChangeDirection()
    {
        // Quay robot theo hướng mới khi va chạm
        float currentAngle = transform.eulerAngles.z;
        float randomTurn = Random.Range(90f, 270f);
        float newAngle = currentAngle + randomTurn;

        transform.rotation = Quaternion.Euler(0, 0, newAngle);
        moveDirection = transform.up;
    }

    public void SetSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }
}