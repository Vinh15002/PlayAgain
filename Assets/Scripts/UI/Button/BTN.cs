using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class  BTN : MonoBehaviour
{
    protected Button btn;

    protected virtual void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() => OnClickBTN());
    }

    public abstract void OnClickBTN();
    
}