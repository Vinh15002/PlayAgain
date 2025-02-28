using Cinemachine;
using System;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public Vector3 postionPlayerDie;
    private CinemachineVirtualCamera vrCam;

    private void Awake()
    {
        vrCam = GetComponent<CinemachineVirtualCamera>();
    }

    private void OnEnable()
    {
        CameraEvent.setTarget += SetTarget;
        CameraEvent.camPlayerDie += SetPlayerDie;
    }

    
    private void OnDisable()
    {
        CameraEvent.setTarget -= SetTarget;
        CameraEvent.camPlayerDie -= SetPlayerDie;
    }

    private void SetTarget(Transform trans)
    {
        vrCam.Follow = trans;
    }

    private void SetPlayerDie()
    {
        vrCam.GetCinemachineComponent<CinemachineFramingTransposer>().m_TrackedObjectOffset = postionPlayerDie;
    }

}

