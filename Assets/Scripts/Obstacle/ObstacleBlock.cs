
using DG.Tweening;

using UnityEngine;

public class ObstacleBlock:MonoBehaviour
{
   
    public void MoveDown()
    {
        this.transform.DOMoveY(-4, 2f);
    }

    
}