using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    
    Rigidbody2D rigidbody2d;
    [SerializeField] Vector2 moveDir;
    [SerializeField] Vector2 jumpDir;
    [SerializeField] float moveSpeed;
    float jumpPower = 5f;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.linearVelocity = moveDir.normalized * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)  //�浹������ �� �ڵ带 �����ϼ���.
    {
        //�浹�� ����� 
        if (collision.collider.CompareTag("Wall"))
        {
            rigidbody2d.linearVelocity = moveDir.normalized * -1 * moveSpeed;
            Debug.Log("���Ͱ� ���� �ε������ϴ�.");
        }

        //���Ͱ� �÷��̾ �浹������ �����ϵ���.

        if (collision.collider.CompareTag("Player"))
        {
            rigidbody2d.AddForce(jumpDir.normalized * jumpPower, ForceMode2D.Impulse);            
            Debug.Log("���Ͱ� �÷��̾ �ε������ϴ�.");
        }
        if (collision.collider.CompareTag("monster"))
        {
            rigidbody2d.AddForce(jumpDir.normalized * jumpPower, ForceMode2D.Impulse);
            Debug.Log("���Ͱ� ���� �ε������ϴ�.");
        }

        //monster�� �̵������ �پ��ϰ� ǥ��

        //�÷��̾� �������� ������ �ϸ鼭 ���� ����(������)
        //�ӵ��� �ٲ㵵 ������ ������� �ٲ㳪���鼭  �̰� �ٲ����� � ��ȭ�� �Ͼ���� 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


