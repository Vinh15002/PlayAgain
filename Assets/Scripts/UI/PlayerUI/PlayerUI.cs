using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{

    [SerializeField] private VariableJoystick joystick;
    [SerializeField] private Button jumpBTN;

    private PlayerController controller;

    private void Start()
    {
        jumpBTN.onClick.AddListener(() => { controller.OnPlayerJump(); });
    }

    private void Update()
    {
        SetDirectionMovement();
        //Debug.Log(joystick.Vertical +": " + joystick.Horizontal);
    }

   

    private void OnEnable()
    {
        PlayerEvent.sentPlayerControl += GetData;
    }
    private void OnDisable()
    {
        PlayerEvent.sentPlayerControl -= GetData;
    }

    private void GetData(PlayerController control)
    {
        controller = control;
        
    }

    private void SetDirectionMovement()
    {
        var x = -joystick.Vertical;
        var z = joystick.Horizontal;
        controller.SetDirectionMovement(new Vector2(x, z));
    }
}