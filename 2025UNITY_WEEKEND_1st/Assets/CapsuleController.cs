using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))] // Rigidbody2D ������Ʈ�� ������ �ڵ����� �߰��ϵ��� �����մϴ�.
public class CapsuleController : MonoBehaviour
{
    // ���� ��� �������� �����ϱ� ���� Rigidbody2D ������Ʈ ����
    private Rigidbody2D rb;

    // ������Ʈ�� �̵��� �ӵ� (Inspector â���� ���� ����)
    public float moveSpeed = 5f;

    // ������ ������ �Է��� ������ ���� ����
    private Vector2 movementInput;

    // ���� ������Ʈ�� Ȱ��ȭ�� �� �� �� ȣ��˴ϴ�.
    private void Awake()
    {
        // ���� ���� ������Ʈ�� �پ��ִ� Rigidbody2D ������Ʈ�� ������ rb ������ �Ҵ��մϴ�.
        rb = GetComponent<Rigidbody2D>();
    }

    // Input System�� ���� 'Move' �׼��� Ʈ���ŵ� ������ �� �޼��尡 ȣ��˴ϴ�.
    public void OnMove(InputAction.CallbackContext context)
    {
        // �Է� �ý������κ��� Vector2 ���� �о� movementInput ������ �����մϴ�.
        movementInput = context.ReadValue<Vector2>();
    }

    // ���� ������Ʈ�� FixedUpdate���� ó���ϴ� ���� �����ϴ�.
    private void FixedUpdate()
    {
        // Rigidbody2D�� �ӵ��� ���� �Է°�(movementInput)�� �̵� �ӵ�(moveSpeed)�� ���� ������ �����մϴ�.
        // �̸� ���� ���� ����� �ε巯�� �������� �����˴ϴ�.
        rb.linearVelocity = movementInput * moveSpeed;
    }
}