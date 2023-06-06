using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class animationState : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("before jump");
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("forward");
            animator.SetBool("isRunning", true);
        } else
        {
            //Debug.Log(" stop jump");
            animator.SetBool("isRunning", false);
        }

    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
