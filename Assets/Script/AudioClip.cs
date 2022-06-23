using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioClip : MonoBehaviour
{
    public static AudioClip Instance;
    public UnityEngine.AudioClip impact;
    AudioSource audioSource;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void clip()
    {
        audioSource.PlayOneShot(impact);
    }
}