using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (animator != null)
        {
            float forward = Input.GetAxis("Vertical");
            float right = Input.GetAxis("Horizontal");

            animator.SetFloat("Forward", forward);
            animator.SetFloat("Right", right);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("Attack");
            }
        }
    }
}
