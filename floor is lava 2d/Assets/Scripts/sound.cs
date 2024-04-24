using UnityEngine;

public class sound : MonoBehaviour
{
    public float yThreshold = 0f; // ѕороговое значение по оси Y, ниже которого будет воспроизводитьс€ звук
    public AudioClip soundClip; // «вук дл€ воспроизведени€

    private AudioSource audioSource;

    void Start()
    {
        // ѕолучаем компонент AudioSource дл€ воспроизведени€ звука
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // ѕровер€ем, если позици€ шарика по оси Y меньше порогового значени€
        if (transform.position.y > yThreshold)
        {
            // ≈сли да, воспроизводим звук
            if (audioSource != null && soundClip != null && !audioSource.isPlaying)
            {
                audioSource.PlayOneShot(soundClip);
            }
        }
    }
}