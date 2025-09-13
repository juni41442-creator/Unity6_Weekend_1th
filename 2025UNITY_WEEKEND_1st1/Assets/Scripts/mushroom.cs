using UnityEngine;

public class mushroom : MonoBehaviour
{
    //transform�̵����� �¿�� �����̴� �ڵ带 �������.
    //���� �浹�Ҽ� �ִ� ��ü�� ������ � "�̺�Ʈ"�� �߻��ؾ� �Ѵ�.

    public float speed = 5f;
    public int direction = 1;   // 1: ������, -1: ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Rand = UnityEngine.Random.Range(0, 2); //0�Ǵ� 1�� ����� �ȴ�.

        if (Rand ==0)
        {
            direction = -1;
        }
        else if(Rand == 1 )
        {
            direction = 1;
        }       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(direction, 0, 0) * speed* Time.deltaTime;
    }

    // Collider�� �ٸ� Collider�� �ε����� �� ȣ��Ǵ� �Լ�
    void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ������Ʈ�� �±װ� "greenpipe"���� Ȯ���մϴ�.
        if (collision.gameObject.CompareTag("Well"))
        {
            // ������ ������ŵ�ϴ�. (������ -> ����, ���� -> ������)
            direction *= -1;

            // �߰������� �ʿ��ϴٸ� ��������Ʈ ���⵵ ������ų �� �ֽ��ϴ�.
            //transform.localScale = new Vector3(direction, 1, 1);
        }
    }

}
