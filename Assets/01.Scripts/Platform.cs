using UnityEngine;

// �������μ� �ʿ��� ������ ���� ��ũ��Ʈ
public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;  // ��ֹ� ������Ʈ��
    private bool stepped = false;   // �÷��̾� ĳ���Ͱ� ��Ҵ°�

    // ������Ʈ�� Ȱ��ȭ�� ������ �Ź� ����Ǵ� �޼���
    private void OnEnable()
    {
        // ������ �����ϴ� ó��
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �÷��̾� ĳ���Ͱ� �ڽ��� ����� �� ������ �߰��ϴ� ó��
    }
}


