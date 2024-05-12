using UnityEngine;
using UnityEngine.UI;

public class AudioSwitcher : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void OnEnable()
    {
        _button.onClick.AddListener(SwitchPause);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(SwitchPause);
    }

    private void SwitchPause()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
