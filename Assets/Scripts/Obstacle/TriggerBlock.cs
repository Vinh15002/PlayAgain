using UnityEngine;

public class TriggerBlock : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponentInParent<ObstacleBlock>().MoveDown();
        }
    }
}