using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AnimationBTN : MonoBehaviour
{
    private Button btn;

    private void Start()
    {
        btn = GetComponent<Button>();   
        float currentScale = this.transform.localScale.x;
        btn.onClick.AddListener(() =>
        {
            transform.DOScale(currentScale*1.5f, 1f);
        });
    }
}