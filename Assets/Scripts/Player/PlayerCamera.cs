
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private void Start()
    {
        CameraEvent.setTarget?.Invoke(this.transform);
    }


    public void SetCamPlayerDie() { 
        
    
    }
}