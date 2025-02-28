using UnityEngine;
using UnityEngine.UI;

public class PlayBTN : BTN
{
    

    public override void OnClickBTN()
    {
        ManagerSound.Instance.PlaySoundSFX(EnumSound.Click);
        ManagerUI.Instance.LoadScenePlay();
    }



}