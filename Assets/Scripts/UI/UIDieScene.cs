using System;
using TMPro;

using UnityEngine;

public class UIDieScene : MonoBehaviour
{
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text iq;


    private void Start()
    {
        SetText();
    }

    private void SetText()
    {
        int getScene = PlayerPrefs.GetInt("Level",1);
        int getIQ = PlayerPrefs.GetInt("IQ",1);

        title.text = $"Level" + getScene;
        iq.text = $"-{getIQ}IQ";

        PlayerPrefs.SetInt("IQ", getIQ + 1);

        ManagerSound.Instance.PlaySoundSFX(EnumSound.Loss);

    }
}