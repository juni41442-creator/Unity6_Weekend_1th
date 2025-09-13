
using UnityEngine;

public class Mario : MonoBehaviour
{
    public float speed = 5f;
    public float JumpForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    //AI�� ��� ����ؾ� �ұ�?

    //�÷��̾��� �̵��� ���� a,dŰ�� ������ �¿�� �����̰� �ʹ�. spaceŰ�� ������ ������ �ϰ� �ʹ�.
    //update�Լ��ȿ��� ���� �Ҽ� �ְ� ����. speed,jumpforce�� ����ؼ� ����� ��������.
    //Tansform �̵����, rigidbody 2d������� �̵�
    //class �̸� Mario�� ����� �޶�.
    //Rigidbody2d �����̴�.
    //���� ��������� �����Ҽ� �ְ� ����.

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical"); //w,s, ��,�Ʒ�

        if(Input.GetKeyDown(KeyCode.Space)) //�÷��̾ ���� ��������� ������ �ض�.
        {
            transform.position = transform.position + new Vector3(0, JumpForce, 0) * Time.deltaTime;
        }
        transform.position = transform.position + new Vector3(x, 0, 0) * speed * Time.deltaTime;
    }
}


/*


using UnityEngine;

public class Mario : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        // Rigidbody2D ������Ʈ�� �����ͼ� ������ �Ҵ��մϴ�.
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. �¿� �̵�: A/D Ű �Ǵ� �¿� ȭ��ǥ Ű �Է��� �޽��ϴ�.
        float horizontalInput = Input.GetAxis("Horizontal");

        // Rigidbody2D�� �ӵ�(velocity)�� ���� �����Ͽ� �̵��� �����մϴ�.
        // y�� �ӵ��� �߷��� �����ϱ� ���� ���� �ӵ��� �״�� ����մϴ�.
        rb.linearVelocity = new Vector2(horizontalInput * speed, rb.linearVelocity.y);

        // 2. ����: �����̽��ٸ� ������ ��, ���� ����ִٸ� �����մϴ�.
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // ���� �������� ���� ���� �����մϴ�.
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    // ĳ���Ͱ� �ٸ� ������Ʈ�� �浹���� �� ȣ��˴ϴ�.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ������Ʈ�� �±װ� "Ground"���� Ȯ���մϴ�.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // ĳ���Ͱ� �ٸ� ������Ʈ���� �������� �� ȣ��˴ϴ�.
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

*/