using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GroupMixer : MonoBehaviour
{
    [SerializeField] private string GroupName;
    [SerializeField] private AudioMixerGroup _masterMixerGroup;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _minVolume;
    [SerializeField] private float _maxVolume;

    private void Awake()
    {
        _slider.minValue = _minVolume;
        _slider.maxValue = _maxVolume;

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

    public void SetVolume()
    {
        _masterMixerGroup.audioMixer.SetFloat(GroupName, Mathf.Log10(_slider.value) * 20);
    }
}
