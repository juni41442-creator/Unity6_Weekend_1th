using UnityEngine;

public class mushroom : MonoBehaviour
{
    //transform이동으로 좌우로 움직이는 코드를 만들어줘.
    //옆에 충돌할수 있는 물체가 있으면 어떤 "이벤트"가 발생해야 한다.

    public float speed = 5f;
    public int direction = 1;   // 1: 오른쪽, -1: 왼쪽

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Rand = UnityEngine.Random.Range(0, 2); //0또는 1이 출력이 된다.

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

    // Collider가 다른 Collider에 부딪혔을 때 호출되는 함수
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 오브젝트의 태그가 "greenpipe"인지 확인합니다.
        if (collision.gameObject.CompareTag("Well"))
        {
            // 방향을 반전시킵니다. (오른쪽 -> 왼쪽, 왼쪽 -> 오른쪽)
            direction *= -1;

            // 추가적으로 필요하다면 스프라이트 방향도 반전시킬 수 있습니다.
            //transform.localScale = new Vector3(direction, 1, 1);
        }
    }

}
