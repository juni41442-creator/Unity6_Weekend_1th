using UnityEngine;
using UnityEngine.InputSystem;

public class Playerjump : MonoBehaviour
{
    Rigidbody2D rigidbody2D; //컴포넌트로 부착한 물리 기능을 rigidbody2D 변수를 이용해서 사용하겠다.

    //[SerializeField] Inspector에 항목을 추가   

    //[SerializeField] float dirX = 1f;
    //[SerializeField] float dirY = 1f;

    [SerializeField] float jumpPower = 5f;
    [SerializeField] Vector2 dir;
    [SerializeField] LayerMask groundLayer; //누가땅인지 설정해주는 것.(Ground, Defult)
    [SerializeField] float GroundDistanceCheck = 2f;


    //플레이어 게임오브젝트 안에 있는 Rigidbody2D 컴포넌트를 igidbody2D 안에 저장하고 싶다.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        //Vector2. up,dowm,left,right 
        //Vector2.up * 5
        //저장을 한다음에 게임을 실행해보세요.

        //rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
       
        //rigidbody2D.AddForce(dir * jumpPower, ForceMode2D.Impulse);
    }
    //Addforce : 힘을 추가하다. 점프 -> 위로 힘을 가한다.
    // Update is called once per frame
    void Update()
    {
        //rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);

        //키입력으로 점프를 하고 싶다.

        //if(Keyboard.current.spaceKey.isPressed)
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()) 
        {
            rigidbody2D.AddForce(dir.normalized  * jumpPower, ForceMode2D.Impulse);
        }
    }

    bool IsGrounded()   //땅을 밝고 있나요?
    {
        return Physics2D.Raycast(transform.position, Vector2.down, GroundDistanceCheck, groundLayer);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3)(Vector2.down * GroundDistanceCheck));
    }
}
