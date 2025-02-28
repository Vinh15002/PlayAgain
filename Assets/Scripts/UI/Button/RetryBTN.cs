using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RetryBTN : BTN
{

    protected override void Start()
    {
        base.Start();

        StartCoroutine(DisplayButton());
        



    }

    protected IEnumerator DisplayButton()
    {
        Vector3 currentScale = transform.localScale;
        transform.localScale = Vector3.zero;
        yield return new WaitForSeconds(1f);
        transform.localScale = currentScale;
    }

    public override void OnClickBTN()
    {
        ManagerUI.Instance.LoadScenePlay();
    }
}