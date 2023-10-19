using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingSystem : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private GameObject settingUI;

    public void OpenUI()
    {
        settingUI.SetActive(true);
        volumeSlider.SetValueWithoutNotify(AudioListener.volume);
    }
    public void SetVolume(float value)
    {
        AudioListener.volume = value;
    }
}
