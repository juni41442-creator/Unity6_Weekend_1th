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
        if (collision.gameObject.CompareTag("Wall") ) 
        {
            // 방향을 반전시킵니다. (오른쪽 -> 왼쪽, 왼쪽 -> 오른쪽)
            direction *= -1;

            // 추가적으로 필요하다면 스프라이트 방향도 반전시킬 수 있습니다.
            //transform.localScale = new Vector3(direction, 1, 1);
        }
       /* else if (collision.gameObject.CompareTag("Player"))
        {
            // 플레이어와 충돌했을 때의 이벤트 처리
            //Debug.Log("플레이어와 충돌했습니다!");
            // 예: 플레이어의 체력을 감소시키거나 게임 오버 처리 등
            // 방향을 반전시킵니다. (오른쪽 -> 왼쪽, 왼쪽 -> 오른쪽)
            //direction *= -1;

            // 플레이어 크기를 1.5배로 키움
            //collision.gameObject.transform.localScale *= 1.5f;

            /*
            // 플레이어 크기를 1.5배로 키움
            Transform playerTransform = collision.gameObject.transform;
            playerTransform.localScale *= 1.5f;

            // 크기 복구 코루틴 시작
            StartCoroutine(ResetPlayerScale(playerTransform));


            // 버섯 오브젝트 제거
            Destroy(gameObject);
            
            Transform playerTransform = collision.gameObject.transform;

            // 원래 크기를 저장
            Vector3 originalScale = playerTransform.localScale;

            // 크기 증가
            playerTransform.localScale = originalScale * 1.5f;

            

            // 버섯 제거
            Destroy(gameObject);

            // 크기 복구 코루틴 시작
            StartCoroutine(ResetPlayerScale(playerTransform, originalScale));


        }*/

    }

    // 코루틴: 5초 후 플레이어 크기 원래대로 복구
    System.Collections.IEnumerator ResetPlayerScale(Transform playerTransform, Vector3 originalScale)
    {
        yield return new WaitForSeconds(5f);

        /*
        // 원래 크기로 복구 (1 / 1.5 = 약 0.666...)
        playerTransform.localScale /= 1.5f;

        */

        // 원래 크기로 복구
        playerTransform.localScale = originalScale;


    }
}


