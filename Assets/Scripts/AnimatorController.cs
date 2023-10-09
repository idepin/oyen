using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;

    public void FlipHorizontal(bool isFlip)
    {
        spriteRenderer.flipX = isFlip;
    }

    public void Run()
    {
        animator.SetBool("isRunning", true);
        animator.SetBool("isJumping", false);
    }

    public void Idle()
    {
        animator.SetBool("isRunning", false);
        animator.SetBool("isJumping", false);
    }

    public void Jump()
    {
        animator.SetBool("isJumping", true);
    }
}
