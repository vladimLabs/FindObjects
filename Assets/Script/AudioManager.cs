using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource uisfxAudioSource;
    public static AudioManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //public void PlayUISfx()
    //{
    //    uisfxAudioSource.Play();
    //}

    //public void PlayEnemySound(AudioSource source, AudioClip clip)
    //{
    //    source.clip = clip;
    //    source.Play();
    //}
}
