using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
    //���� ������ public, private + ��ȯ�� Ÿ�� ���� void, int, string  + �Լ��� �̸� + (   )

    public void ButtonPlay()
    {
        Debug.Log("�÷��� ��ư�� ����Ǿ����ϴ�.");
        SceneManager.LoadScene(1);
    }

    public void ButtonLevelEditer()
    {
        Debug.Log("�������� ��ư�� ����Ǿ����ϴ�.");
    }

    public void ButtonSetting()
    {
        Debug.Log("�������� ��ư�� ����Ǿ����ϴ�.");
    }
    public void ButtonNews()
    {
        Debug.Log("�������� ��ư�� ����Ǿ����ϴ�.");
    }
    public void ButtonWish()
    {
        Debug.Log("�������� ��ư�� ����Ǿ����ϴ�.");
    }
    public void ButtonDiscorad()
    {
        Debug.Log("�������� ��ư�� ����Ǿ����ϴ�.");
    }
}
