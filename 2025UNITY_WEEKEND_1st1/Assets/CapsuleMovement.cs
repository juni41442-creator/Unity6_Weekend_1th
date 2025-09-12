using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]

public class CapsuleMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ�

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �Է� ó��
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D �Ǵ� ��/��
        movement.y = Input.GetAxisRaw("Vertical");   // W/S �Ǵ� ��/��
    }

    void FixedUpdate()
    {
        // ���� ��� �̵�
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}