using UnityEngine;

public class ball : MonoBehaviour
{
    void Update()
    {
        // ���������, ���� ������� ������ �� ��� Y ������ 0
        if (transform.position.y < -10)
        {
            // ���� ��, �� �������� �����
            gameObject.SetActive(false);
            Debug.Log("����� ����� � ���"); // ������� ��������� � ������� (����� �������� �� ���� ���)
        }
    }
}