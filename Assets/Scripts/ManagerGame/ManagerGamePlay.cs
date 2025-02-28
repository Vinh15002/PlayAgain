
using UnityEngine;

public class ManagerGamePlay : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerEvent.playerDieEnvent += ChangeScene;
    }

   
    private void OnDisable()
    {
        PlayerEvent.playerDieEnvent += ChangeScene;
    }

    private void ChangeScene()
    {
      
        ManagerUI.Instance.ChangeScene(EnumNameScene.DieScene, 2f);
    }

}