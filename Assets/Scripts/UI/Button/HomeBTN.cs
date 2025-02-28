using UnityEngine;

public class HomeBTN : BTN
{
    public override void OnClickBTN()
    {
        ManagerUI.Instance.ChangeScene(EnumNameScene.MainScene, 0f);
    }
}