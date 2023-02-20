using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Animation : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("walkCount", animator.GetInteger("walkCount") - 1);
    }
}
