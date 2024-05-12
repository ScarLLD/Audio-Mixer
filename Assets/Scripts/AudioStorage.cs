using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AudioStorage : MonoBehaviour
{
    [SerializeField] private Transform _audiosParent;

    private AudioSource[] _audios;

    public List<AudioSource> GetAudios => _audios.ToList();

    private void Awake()
    {
        _audios = new AudioSource[_audiosParent.childCount];

        for (int i = 0; i < _audios.Length; i++)
        {
            if (_audiosParent.GetChild(i).TryGetComponent(out AudioSource audioSource))
                _audios[i] = audioSource;
        }
    }
}
