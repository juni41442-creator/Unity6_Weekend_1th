using UnityEngine;
using UnityEngine.InputSystem;

public class Playerjump : MonoBehaviour
{
    Rigidbody2D rigidbody2D; //������Ʈ�� ������ ���� ����� rigidbody2D ������ �̿��ؼ� ����ϰڴ�.

    //[SerializeField] Inspector�� �׸��� �߰�   

    //[SerializeField] float dirX = 1f;
    //[SerializeField] float dirY = 1f;

    [SerializeField] float jumpPower = 5f;
    [SerializeField] Vector2 dir;
    [SerializeField] LayerMask groundLayer; //���������� �������ִ� ��.(Ground, Defult)
    [SerializeField] float GroundDistanceCheck = 2f;


    //�÷��̾� ���ӿ�����Ʈ �ȿ� �ִ� Rigidbody2D ������Ʈ�� igidbody2D �ȿ� �����ϰ� �ʹ�.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        //Vector2. up,dowm,left,right 
        //Vector2.up * 5
        //������ �Ѵ����� ������ �����غ�����.

        //rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
       
        //rigidbody2D.AddForce(dir * jumpPower, ForceMode2D.Impulse);
    }
    //Addforce : ���� �߰��ϴ�. ���� -> ���� ���� ���Ѵ�.
    // Update is called once per frame
    void Update()
    {
        //rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);

        //Ű�Է����� ������ �ϰ� �ʹ�.

        //if(Keyboard.current.spaceKey.isPressed)
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()) 
        {
            rigidbody2D.AddForce(dir.normalized  * jumpPower, ForceMode2D.Impulse);
        }
    }

    bool IsGrounded()   //���� ��� �ֳ���?
    {
        return Physics2D.Raycast(transform.position, Vector2.down, GroundDistanceCheck, groundLayer);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3)(Vector2.down * GroundDistanceCheck));
    }
}
