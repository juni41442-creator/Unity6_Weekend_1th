using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
    //접근 지정자 public, private + 반환값 타입 선언 void, int, string  + 함수의 이름 + (   )

    public void ButtonPlay()
    {
        Debug.Log("플레이 버튼이 실행되었습니다.");
        SceneManager.LoadScene(1);
    }

    public void ButtonLevelEditer()
    {
        Debug.Log("레벨제작 버튼이 실행되었습니다.");
    }

    public void ButtonSetting()
    {
        Debug.Log("레벨제작 버튼이 실행되었습니다.");
    }
    public void ButtonNews()
    {
        Debug.Log("레벨제작 버튼이 실행되었습니다.");
    }
    public void ButtonWish()
    {
        Debug.Log("레벨제작 버튼이 실행되었습니다.");
    }
    public void ButtonDiscorad()
    {
        Debug.Log("레벨제작 버튼이 실행되었습니다.");
    }
}
