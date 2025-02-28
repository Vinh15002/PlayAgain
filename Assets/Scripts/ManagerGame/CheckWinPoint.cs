using UnityEngine;

public class CheckWinPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ManagerSound.Instance.PlaySoundSFX(EnumSound.Win);
            ManagerUI.Instance.LoadNextScene();
        }
    }
}