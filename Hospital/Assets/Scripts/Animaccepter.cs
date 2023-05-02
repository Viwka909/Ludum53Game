using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace animcontrol
{
    public class Animaccepter : MonoBehaviour
    {
        [SerializeField] public Animator animator;
        void Update()
        {
            if (AnimCtrl.Instance.MoveRight && AnimCtrl.Instance.MoveLeft)
            {
                return;
            }
            if (AnimCtrl.Instance.MoveRight)
            {
                animator.SetBool("Move", true);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            }
            if (AnimCtrl.Instance.MoveLeft)
            {
                animator.SetBool("Move", true);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, -90, 0f);
            }
            if (AnimCtrl.Instance.Jumped)
            {
                animator.SetBool("Jump", true);
            }
            if (!AnimCtrl.Instance.MoveRight && !AnimCtrl.Instance.MoveLeft)
            {
                animator.SetBool("Move", false);
            }
            if (!AnimCtrl.Instance.Jumped)
            {
                animator.SetBool("Jump", false);
            }
        }
    }
}

