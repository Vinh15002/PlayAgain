using DG.Tweening;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetTrigger(AnimationString.IsDie1);
        ProcessAnim();




    }

    private void ProcessAnim()
    {
        transform.localScale = Vector3.zero;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        var sequence = DOTween.Sequence();
        sequence.Join(transform.DOScale(2f, 2f));
        sequence.Join(transform.DORotate(new Vector3(0, -180, 0), 1f));
        sequence.Play();
    }
}