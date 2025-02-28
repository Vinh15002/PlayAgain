using UnityEngine;

public class CameraEvent
{
    public delegate void SetTarget(Transform trans);

    public static SetTarget setTarget;


    public delegate void CamPlayerDieEvent();
    public static CamPlayerDieEvent camPlayerDie;
}