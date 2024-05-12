using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class AudioSourceInitializer : MonoBehaviour
{
    [SerializeField] private Button _button;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(PlayAudio);
    }

    private void PlayAudio()
    {
        _audioSource.Play();
    }
}
