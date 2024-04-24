using UnityEngine;

public class end_sound: MonoBehaviour
{
    public AudioClip soundClip; // Переменная для звукового файла
    private bool hasPlayed = false; // Флаг, чтобы звук воспроизводился только один раз

    void Update()
    {
        // Проверка позиции мячика по оси Y
        if (transform.position.y < -3.5f && !hasPlayed)
        {
            // Воспроизводим звук в позиции мячика
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null && soundClip != null)
            {
                audioSource.PlayOneShot(soundClip);
                hasPlayed = true; // Устанавливаем флаг, чтобы звук воспроизводился только один раз
            }
        }
    }
}
