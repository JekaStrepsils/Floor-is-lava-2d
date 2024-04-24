using UnityEngine;

public class sound : MonoBehaviour
{
    public float yThreshold = 0f; // ��������� �������� �� ��� Y, ���� �������� ����� ���������������� ����
    public AudioClip soundClip; // ���� ��� ���������������

    private AudioSource audioSource;

    void Start()
    {
        // �������� ��������� AudioSource ��� ��������������� �����
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // ���������, ���� ������� ������ �� ��� Y ������ ���������� ��������
        if (transform.position.y > yThreshold)
        {
            // ���� ��, ������������� ����
            if (audioSource != null && soundClip != null && !audioSource.isPlaying)
            {
                audioSource.PlayOneShot(soundClip);
            }
        }
    }
}