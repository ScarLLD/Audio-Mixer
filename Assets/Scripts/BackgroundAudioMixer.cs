using UnityEngine;
using UnityEngine.UI;

public class BackgroundAudioMixer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        _slider.minValue = 0;
        _slider.maxValue = 1;

        SetVolume();
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(delegate { SetVolume(); });
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(delegate { SetVolume(); });
    }

    private void SetVolume()
    {
        _audioSource.volume = _slider.value;
    }
}
