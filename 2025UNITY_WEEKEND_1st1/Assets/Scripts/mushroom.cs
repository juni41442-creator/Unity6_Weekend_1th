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
        if (collision.gameObject.CompareTag("Wall") ) 
        {
            // ������ ������ŵ�ϴ�. (������ -> ����, ���� -> ������)
            direction *= -1;

            // �߰������� �ʿ��ϴٸ� ��������Ʈ ���⵵ ������ų �� �ֽ��ϴ�.
            //transform.localScale = new Vector3(direction, 1, 1);
        }
       /* else if (collision.gameObject.CompareTag("Player"))
        {
            // �÷��̾�� �浹���� ���� �̺�Ʈ ó��
            //Debug.Log("�÷��̾�� �浹�߽��ϴ�!");
            // ��: �÷��̾��� ü���� ���ҽ�Ű�ų� ���� ���� ó�� ��
            // ������ ������ŵ�ϴ�. (������ -> ����, ���� -> ������)
            //direction *= -1;

            // �÷��̾� ũ�⸦ 1.5��� Ű��
            //collision.gameObject.transform.localScale *= 1.5f;

            /*
            // �÷��̾� ũ�⸦ 1.5��� Ű��
            Transform playerTransform = collision.gameObject.transform;
            playerTransform.localScale *= 1.5f;

            // ũ�� ���� �ڷ�ƾ ����
            StartCoroutine(ResetPlayerScale(playerTransform));


            // ���� ������Ʈ ����
            Destroy(gameObject);
            
            Transform playerTransform = collision.gameObject.transform;

            // ���� ũ�⸦ ����
            Vector3 originalScale = playerTransform.localScale;

            // ũ�� ����
            playerTransform.localScale = originalScale * 1.5f;

            

            // ���� ����
            Destroy(gameObject);

            // ũ�� ���� �ڷ�ƾ ����
            StartCoroutine(ResetPlayerScale(playerTransform, originalScale));


        }*/

    }

    // �ڷ�ƾ: 5�� �� �÷��̾� ũ�� ������� ����
    System.Collections.IEnumerator ResetPlayerScale(Transform playerTransform, Vector3 originalScale)
    {
        yield return new WaitForSeconds(5f);

        /*
        // ���� ũ��� ���� (1 / 1.5 = �� 0.666...)
        playerTransform.localScale /= 1.5f;

        */

        // ���� ũ��� ����
        playerTransform.localScale = originalScale;


    }
}


