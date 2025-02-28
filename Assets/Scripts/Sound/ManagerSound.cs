using System.Collections.Generic;
using UnityEngine;

public class ManagerSound : MonoBehaviour
{

    public static ManagerSound Instance;
    public Sound Background;

    public Transform SFX;

    private Dictionary<EnumSound, Sound> sfxSounds;

    private void Start()
    {
        DontDestroyOnLoad(this);
        Instance = this;
        sfxSounds = new Dictionary<EnumSound, Sound>();

        for(int i = 0;  i < SFX.childCount; i++) {
            int index = 100;
            sfxSounds[(EnumSound)(index+i)] = SFX.GetChild(i).GetComponent<Sound>();
        }
        
    }


    public void PlaySoundSFX(EnumSound soundName)
    {
        sfxSounds[soundName].GetSound().Play();
    }
}