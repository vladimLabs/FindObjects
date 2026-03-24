using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] private Slider master;
    [SerializeField] private AudioMixer mixer;

    private const string master_Volume = "Master";


    private void Awake()
    {
        master.onValueChanged.AddListener(SetMasterVolume);
    }

    private void Start()
    {
        TryLoadVolume(master_Volume, master, SetMasterVolume);
    }

    private void SetMasterVolume(float value)
    {
        mixer.SetFloat(master_Volume, GetMixerVolume(value));
        SaveVolume(master_Volume, value);
    }

    private float GetMixerVolume(float value) =>
    Mathf.Log10(value) * 20;

    private void SaveVolume(string channel, float value)
    {
        PlayerPrefs.SetFloat(channel, value);
    }

    private void TryLoadVolume(string channel, Slider slider, Action<float> loadCallback)
    {
        if (PlayerPrefs.HasKey(channel))
        {
            float value = PlayerPrefs.GetFloat(channel);
            loadCallback.Invoke(value);
            slider.value = value;
        }
    }
}
