using UnityEngine;

public class end_sound: MonoBehaviour
{
    public AudioClip soundClip; // ���������� ��� ��������� �����
    private bool hasPlayed = false; // ����, ����� ���� ��������������� ������ ���� ���

    void Update()
    {
        // �������� ������� ������ �� ��� Y
        if (transform.position.y < -3.5f && !hasPlayed)
        {
            // ������������� ���� � ������� ������
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null && soundClip != null)
            {
                audioSource.PlayOneShot(soundClip);
                hasPlayed = true; // ������������� ����, ����� ���� ��������������� ������ ���� ���
            }
        }
    }
}
