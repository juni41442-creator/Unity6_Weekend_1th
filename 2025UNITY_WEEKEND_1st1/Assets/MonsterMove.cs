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

    void OnCollisionEnter2D(Collision2D collision)  //충돌했을때 이 코드를 실행하세요.
    {
        //충돌한 대상이 
        if (collision.collider.CompareTag("Wall"))
        {
            rigidbody2d.linearVelocity = moveDir.normalized * -1 * moveSpeed;
            Debug.Log("몬스터가 벽에 부딪혔습니다.");
        }

        //몬스터가 플레이어가 충돌했을때 점프하도록.

        if (collision.collider.CompareTag("Player"))
        {
            rigidbody2d.AddForce(jumpDir.normalized * jumpPower, ForceMode2D.Impulse);            
            Debug.Log("몬스터가 플레이어에 부딪혔습니다.");
        }
        if (collision.collider.CompareTag("monster"))
        {
            rigidbody2d.AddForce(jumpDir.normalized * jumpPower, ForceMode2D.Impulse);
            Debug.Log("몬스터가 서로 부딪혔습니다.");
        }

        //monster의 이동방식을 다양하게 표현

        //플레이어 방향으로 점프를 하면서 오는 패턴(개구리)
        //속도만 바꿔도 게임을 어느정도 바꿔나가면서  이걸 바꿨을때 어떤 변화가 일어나는지 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


